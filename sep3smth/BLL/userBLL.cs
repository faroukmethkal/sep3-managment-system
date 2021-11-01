using BlazorSep3LoginExample.DAL;
using System.Data;
using System.Data.SqlClient;

namespace BlazorSep3LoginExample.BLL
{
    public class userBLL
    {
        private SqlConnection con = new SqlConnection(@"");

        public DataTable login(userDAL user)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand command =
                new SqlCommand(
                    "SELECT * FROM USERS WHERE USERNAME='" + user.username+"'AND PASSWORD='" + user.password + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            return dt;
        }
    }
}