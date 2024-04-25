using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlHelper
    {
        private SqlConnection sqlConnection;

        public SqlHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public int ExecuteNonQuery(string command, Dictionary<string,object> parameters) 
        {
            SqlCommand sqlCommand = createCommand(command, parameters);
            sqlCommand.Connection.Open();
            var affectedRows = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return affectedRows;
        }

        private SqlCommand createCommand(string command, Dictionary<string, object> parameters)
        {
            var sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = command;
            addParametersToCommand(sqlCommand, parameters);
            return sqlCommand;

        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}
