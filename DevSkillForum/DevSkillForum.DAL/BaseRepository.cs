using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DevSkillForum.DAL
{
    public abstract class BaseRepository
    {
        protected DbConnection Connection { get; set; }

        protected virtual void OpenConnection()
        {
            if (Connection == null)
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString);

            if (Connection != null && Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        protected virtual void CloseConnection()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        protected virtual DbCommand CreateCommand(string commandText)
        {
            return new SqlCommand(commandText, (SqlConnection)Connection);
        }

        protected virtual DbParameter CreateParameter(string name, object value)
        {
            return new SqlParameter(name, value);
        }
    }
}
