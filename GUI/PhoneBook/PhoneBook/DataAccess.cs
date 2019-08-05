using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PhoneBook
{
    class DataAccess
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PhoneBook"].ToString();
            return new SqlConnection(connectionString);
        }

        public static DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        static DataTable GetDataWithParameters(string sql, params SqlParameter[] Params)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(Params);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int ExecuteSql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            // INSERT, DELETE, UPDATE...
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
        public static DataTable checkExistedPhone(string phone)
        {
            string sql = "select * from PhoneAddress where PhoneNumber = @phone";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.VarChar);
            param1.Value = phone;
            return GetDataWithParameters(sql, param1);
        }

        public static int Delete(string phone)
        {
            string sql = "delete from PhoneAddress where PhoneNumber = @phone";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.VarChar);
            param1.Value = phone;
            return ExecuteSql(sql, param1);
        }

        public static int Insert(string phoneNumber, string firstName, string lastName, string address)
        {
            string sql = "INSERT INTO PhoneAddress([PhoneNumber],[FirstName],[LastName],[Address]) "+
                "VALUES(@phone, @first, @last, @address)";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.VarChar);
            param1.Value = phoneNumber;
            SqlParameter param2 = new SqlParameter("@first", SqlDbType.NVarChar);
            param2.Value = firstName;
            SqlParameter param3 = new SqlParameter("@last", SqlDbType.NVarChar);
            param3.Value = lastName;
            SqlParameter param4 = new SqlParameter("@address", SqlDbType.NVarChar);
            param4.Value = address;
            return ExecuteSql(sql, param1, param2, param3, param4);
        }

        public static DataTable GetPhoneAddressByPhoneNumber(string phoneNumber)
        {
            string sql = @"SELECT [PhoneNumber]
                        ,[FirstName]
                         ,[LastName]
                        ,[Address]
                         FROM [PhoneAddress].[dbo].[PhoneAddress] WHERE PhoneNumber = @phone";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.VarChar);
            param1.Value = phoneNumber;
            return GetDataWithParameters(sql, param1);
        }

        public static DataTable GetAllPhoneAddress()
        {
            string sql = @"SELECT [PhoneNumber]
                        ,[FirstName]
                         ,[LastName]
                        ,[Address]
                         FROM [PhoneAddress].[dbo].[PhoneAddress]
                        ORDER BY [FirstName]";

            return GetDataBySql(sql);
        }

        public static DataTable SearchPhoneAddress(string phoneNumber, string firstName, string lastName, string address)
        {
            string sql = @"select * from PhoneAddress 
                            where PhoneNumber like '%'+@phone+'%' and FirstName like '%'+@first+'%' 
                            and LastName like '%'+@last+'%' and [Address] like '%'+@address+'%'
                            order by FirstName, LastName";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.VarChar);
            param1.Value = phoneNumber;
            SqlParameter param2 = new SqlParameter("@first", SqlDbType.NVarChar);
            param2.Value = firstName;
            SqlParameter param3 = new SqlParameter("@last", SqlDbType.NVarChar);
            param3.Value = lastName;
            SqlParameter param4 = new SqlParameter("@address", SqlDbType.NVarChar);
            param4.Value = address;

            return GetDataWithParameters(sql, param1, param2, param3, param4);
        }

        public static void DeletePhoneAddress(string phoneNumber)
        {
            string sql = @"DELETE FROM PhoneAddress WHERE phoneNumber = @phoneNumber";
            SqlParameter param1 = new SqlParameter("@phoneNumber", SqlDbType.VarChar);
            param1.Value = phoneNumber;

            ExecuteSql(sql, param1);
        }
    }
}
