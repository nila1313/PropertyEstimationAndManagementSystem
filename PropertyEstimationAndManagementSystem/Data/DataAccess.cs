﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using PropertyEstimationAndManagementSystem.Entites;
/// <summary>
/// by M. Abrar Fahad
/// </summary>
namespace PropertyEstimationAndManagementSystem.Data
{
    public class DataAccess
    {
        private string ConnectionString { get; set; }

        public DataAccess()
        {
            string currentLocation = Directory.GetCurrentDirectory();
            string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
            ConnectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\MainDatabase.mdf;Integrated Security=True;Connect Timeout=30", projectDir);
        }

        private SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;

        }


        public int Insert<T>(T entity, bool isIDIdentity) where T : BaseEntity
        {
            T t = GetById<T, int>(entity.Id);
            SqlCommand sqlCommand;
            if (t != null)
            {
                sqlCommand = getUpdateQuery<T>(entity);
            }
            else
            {
                sqlCommand = getInsertQuery<T>(entity, isIDIdentity);
            }

            //SqlCommand sqlCommand = GetCommand(sqlQuery);
            sqlCommand.Connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }

        private SqlCommand getUpdateQuery<T>(T entity) where T : BaseEntity
        {

            var _column = "";
            var _value = "";
            var sql = "UPDATE  [" + entity.GetType().Name + "] SET ";
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (prop.Name != "Id")
                {
                    _column = string.Format("[{0}]", prop.Name);
                    _value = string.Format("@{0}", prop.Name, prop.GetValue(entity, null));
                    sql += string.Format("{0}={1},", _column, _value);
                }
            }
            sql = sql.TrimEnd(',');
            sql += " where Id='" + entity.Id + "'";
            SqlCommand sqlcommand = GetCommand(sql);
            foreach (var prop in entity.GetType().GetProperties())
            {
                sqlcommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity, null).ToString());
            }
            return sqlcommand;
        }

        private SqlCommand getInsertQuery<T>(T entity, bool isIDIdentity) where T : BaseEntity
        {
            var columns = "";
            var values = "";
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (prop.Name == "Id" && isIDIdentity)
                {
                    continue;
                }
                else
                {
                    columns += string.Format("[{0}],", prop.Name);
                    values += string.Format("@{0},", prop.Name, prop.GetValue(entity, null));
                }
            }
            columns = columns.TrimEnd(',');
            values = values.TrimEnd(',');
            string sql1 = "INSERT INTO [" + entity.GetType().Name + "] (" + columns + ") values(" + values + " )";
            SqlCommand sqlcommand = GetCommand(sql1);
            foreach (var prop in entity.GetType().GetProperties())
            {
                sqlcommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity, null).ToString());
            }
            return sqlcommand;
        }

        ///
        /// Get Query
        ///

        public List<T> GetList<T>(string whereClause = "") where T : BaseEntity
        {
            DataTable dataTable = Execute(getSelectQuery<T>(whereClause));
            return getEntityListFromDataTable<T>(dataTable);
        }

        public T GetById<T, IdType>(IdType id) where T : BaseEntity
        {
            DataTable dataTable = Execute(getSelectQuery<T>(" where Id=" + id + ";"));
            var t = getEntityListFromDataTable<T>(dataTable).FirstOrDefault<T>();
            return t;
        }


        public DataTable GetData<T>(string whereClause) where T : BaseEntity
        {
            return Execute(getSelectQuery<T>(whereClause));
        }

        private List<T> getEntityListFromDataTable<T>(DataTable dataTable) where T : BaseEntity
        {
            List<T> entities = new List<T>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //T t2 = new T();
                T t = (T)Activator.CreateInstance(typeof(T));
                foreach (var prop in t.GetType().GetProperties())
                {
                    var ValType = prop.PropertyType;
                    prop.SetValue(t, System.Convert.ChangeType(dataTable.Rows[i][prop.Name].ToString(), prop.PropertyType));
                }
                entities.Add(t);
            }
            return entities;
        }


        private string getSelectQuery<T>(string whereClause = "") where T : BaseEntity
        {
            string sql1 = "Select ";
            var entity = (T)Activator.CreateInstance(typeof(T));// new Property()
            foreach (var prop in entity.GetType().GetProperties())
            {
                sql1 += string.Format("[{0}],", prop.Name);
            }

            sql1 = sql1.TrimEnd(',');
            sql1 += " from [" + entity.GetType().Name + "] " + whereClause;
            return sql1;
        }

        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        public int remove<T>(T entity) where T : BaseEntity
        {
            var sql = string.Format("DELETE FROM {0} WHERE Id={1}", entity.GetType().Name,entity.Id.ToString());
            SqlCommand sqlCommand = GetCommand(sql);
            sqlCommand.Connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }
        public int remove<T>(string whereClause) where T : BaseEntity
        {
            var entity = (T)Activator.CreateInstance(typeof(T));
            var sql = string.Format("DELETE FROM {0} {1}", entity.GetType().Name,whereClause);
            SqlCommand sqlCommand = GetCommand(sql);
            sqlCommand.Connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }
    }
}
