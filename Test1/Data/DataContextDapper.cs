using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Test1.Data
{
    class DataContextDapper
    {
        private string connectionString =
                @"Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;
                Trusted_Connection=false;User Id=sa;Password=SQLConnect1;";
        private readonly IDbConnection _dbConnection;

        public DataContextDapper()
        {
            //Open the db connection
            this._dbConnection = new SqlConnection(connectionString);
        }

        public int ExecuteSql(string sqlQuery)
        {
            return _dbConnection.Execute(sqlQuery);
        }

        public IEnumerable<T> GetRecords<T>(string sqlQuery)
        {
            //Dapper call
            return _dbConnection.Query<T>(sqlQuery);
        }

        public T GetRecord<T>(string sqlQuery)
        {
            return _dbConnection.QuerySingle<T>(sqlQuery);
        }
    }
}