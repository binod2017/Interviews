using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public static class DataAccess
    {
        private static string connectionString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["InterviewConnectionString"]
                    .ToString();
            }
        }
        internal static DataTable GetAllRecordsInt(bool p)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select Company, Recruiter, EventDate, EventTime, Status, EventDate1, Status1, Result, " +
                    "InterviewMonth, InterviewYear, Active from [InterviewStatus$]";// ORDER BY MONTH(EventDate) DESC, DAY(EventDate) DESC ";

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
        internal static DataTable GetLastIdInt()
        {
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter OleDbDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                OleDbDbDataAdapter.SelectCommand = new OleDbCommand();
                OleDbDbDataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                OleDbDbDataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                OleDbDbDataAdapter.SelectCommand.CommandText = " SELECT COUNT(*) From [InterviewStatus$]"; ;
                // Fill the datatable from adapter
                OleDbDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        public static string ConvertIntToMonth(int mth)
        {
            string result = "";
            switch (mth)
            {
                case 1:
                    result = "Jan";
                    break;

                case 2:
                    result = "Feb";
                    break;
                case 3:
                    result = "Mar";
                    break;
                case 4:
                    result = "Apr";
                    break;
                case 5:
                    result = "May";
                    break;
                case 6:
                    result = "Jun";
                    break;
                case 7:
                    result = "Jul";
                    break;
                case 8:
                    result = "Aug";
                    break;
                case 9:
                    result = "Sep";
                    break;
                case 10:
                    result = "Oct";
                    break;
                case 11:
                    result = "Nov";
                    break;
                case 12:
                    result = "Dec";
                    break;
                default:
                    break;
            }
            return result;
        }
        internal static bool UpdateInterview(InterviewModel interview)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(connectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = "Update [InterviewStatus$] " +
                " Set [EventDate1] = @eventdate, [EventTime1] = @eventtime, [Status1] = @status, [Result] = @result " +
                "Where ([SlNo] = @slnos)";

                // Add the input parameters to the parameter collection
                //dbCommand.Parameters.AddWithValue("@company", interview.Company);
                dbCommand.Parameters.AddWithValue("@eventdate", interview.EventDate1);
                dbCommand.Parameters.AddWithValue("@eventtime", interview.EventTime1);
                dbCommand.Parameters.AddWithValue("@status", interview.Status1);
                dbCommand.Parameters.AddWithValue("@result", interview.Result);
                //dbCommand.Parameters.AddWithValue("@interviewmonth", interview.InterviewMonth);
                //dbCommand.Parameters.AddWithValue("@interviewyear", interview.InterviewYear);
                dbCommand.Parameters.AddWithValue("@slnos", interview.SlNo);
                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        internal static bool AddDetailsInt(InterviewModel interview)
        {
            var rowsAffected = 0;

            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(connectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = "Insert Into [InterviewStatus$](SlNo, Company, Recruiter, EventDate,EventTime, Status, Result, InterviewMonth, InterviewYear, Active )" +
            " Values (@slnos, @company, @recruiter, @eventDate, @eventTime, @status, @result, @interviewMonth, @interviewYear, @active)";

                // Update the input parameters to the parameter collection
                dbCommand.Parameters.AddWithValue("@slnos", interview.SlNo);
                dbCommand.Parameters.AddWithValue("@company", interview.Company);
                dbCommand.Parameters.AddWithValue("@recruiter", interview.Recruiter);
                dbCommand.Parameters.AddWithValue("@eventDate", interview.EventDate);
                dbCommand.Parameters.AddWithValue("@eventTime", interview.EventTime);
                dbCommand.Parameters.AddWithValue("@status", interview.Status);
                dbCommand.Parameters.AddWithValue("@result", interview.Result);
                dbCommand.Parameters.AddWithValue("@interviewMonth", interview.InterviewMonth);
                dbCommand.Parameters.AddWithValue("@interviewYear", interview.InterviewYear);
                dbCommand.Parameters.AddWithValue("@active", interview.Active);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
            }
            return rowsAffected > 0;
        }
        internal static bool DeleteInterview(int slnos)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(connectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = "Update [InterviewStatus$] Set Active = false Where SlNo = @slnos";

                // Add the input parameters to the parameter collection
                dbCommand.Parameters.AddWithValue("@slnos", slnos);

                // Open the connection, execinterview.SlNoshe query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
        internal static DataTable GetAllRecordsIntActive()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select SlNo, Company, Recruiter, EventDate, Status, EventDate1, Status1, Result  from [InterviewStatus$] where Active = true ORDER BY MONTH(EventDate) DESC, DAY(EventDate)";

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@active", true);
                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
        internal static DataTable GetAllRecordsIntDeActive()
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select SlNo, Company, Recruiter, EventDate, Status, EventDate1, Status1, Result from [InterviewStatus$] where Active = false";

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@active", false);
                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
        internal static DataTable GetAllRecordsByMonth(string mth)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select Company, Recruiter, InterviewMonth, InterviewYear, Status, Status1, Result from [InterviewStatus$] where InterviewMonth = @month";

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@month", mth);
                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        internal static DataRow GetInterviewDetailsById(int slnos)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(connectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = "Select SlNo, Company, Recruiter, EventDate, EventTime, Status, Status1 from [InterviewStatus$] where SlNo = @slnos";

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@slnos", slnos);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }
    }
}
