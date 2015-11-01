using DataEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLayer
{
    public class DUserInteractions
    {
        SqlConnection conn = null;

        public DUserInteractions(string connstr)
        {
            conn = new SqlConnection(connstr);
        }

        private readonly string InsertUserLogs = @"INSERT INTO [dbo].[UserLogs]([Content],[ControlType],[ControlUsageCount],[Hostname],[Pagename]
                                                ,[PageUsageTime],[UserEnter],[UserExit],[UserIp],[UserAgent])
                                                VALUES(@Content,@ControlType,@ControlUsageCount,@Hostname,@Pagename,@PageUsageTime,@UserEnter,@UserExit,@UserIp,@UserAgent)";
        private readonly string SelectUserLogs = @"SELECT * FROM UserLogs";
        public void Insert(UserLogs objUserLogs)
        {
            string sqlQuery = InsertUserLogs;
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.Add(new SqlParameter("Content", objUserLogs.Content));
                cmd.Parameters.Add(new SqlParameter("ControlType", objUserLogs.ControlType));
                cmd.Parameters.Add(new SqlParameter("ControlUsageCount", objUserLogs.ControlUsageCount));
                cmd.Parameters.Add(new SqlParameter("Hostname", objUserLogs.Hostname));
                cmd.Parameters.Add(new SqlParameter("Pagename", objUserLogs.Pagename));
                cmd.Parameters.Add(new SqlParameter("PageUsageTime", objUserLogs.PageUsageTime));
                cmd.Parameters.Add(new SqlParameter("UserEnter", objUserLogs.UserEnter));
                cmd.Parameters.Add(new SqlParameter("UserExit", objUserLogs.UserExit));
                cmd.Parameters.Add(new SqlParameter("UserIp", objUserLogs.UserIp));
                cmd.Parameters.Add(new SqlParameter("UserAgent", objUserLogs.UserAgent));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
