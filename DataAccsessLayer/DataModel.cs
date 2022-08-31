using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }
        public List<User> GetUser()
        {
            try
            {
                List<User> users = new List<User>();
                cmd.CommandText = "SELECT ID,Name,Surname FROM Users";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User { ID = reader.GetInt32(0), Name = reader.GetString(1),Surname=reader.GetString(2) });
                }
                return users;
            }
            finally
            {
                con.Close();
            }
        }
        public List<User2> GetUser1()
        {
            try
            {
                List<User2> users = new List<User2>();
                cmd.CommandText = "SELECT ID,Name,Surname FROM Users";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                    users.Add(new User2 { ID = reader.GetInt32(0), Fullname = $"{name} {surname}" });
                }
                return users;
            }
            finally
            {

            }
        }
    }
}
