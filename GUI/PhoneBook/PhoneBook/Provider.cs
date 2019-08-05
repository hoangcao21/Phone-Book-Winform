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
    public class PhoneAddress
    {
        public string PhoneNumber
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public PhoneAddress(string phoneNumber, string firstName, string lastName, string address)
        {
            this.PhoneNumber = phoneNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
        public static bool checkPhoneNumber(string phone)
        {
            //bool ret = true;
            //string check = "0123456789";
            phone = phone.Replace(" ", "");
            if (phone.Length != 10 && phone.Length != 11) return false; //moi sua
            if (phone[0] != '0') return false; //moi sua
            for(int i=0; i<phone.Length; i++)
            {
                if (!Char.IsNumber(phone[i])) return false; //moi sua
            }
            return true;
        }
        public static string PhoneForming(string phone)
        {
            phone = phone.Replace(" ", "");
            string phone1 = phone.Insert(4," ");
            string phone2 = phone1.Insert(8," ");
            return phone2;
        }
        public static bool checkPhone(string phone)
        {
            DataTable dt = DataAccess.checkExistedPhone(phone);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }
        public static bool checkName(string name)
        {
            if (name.Length < 1) return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(name , @"^[a-z A-Z]+$"))
            {
                return true;
            }
            else
            return false;
        }
        public static List<PhoneAddress> GetPhoneAddressByPhoneNumber(string phoneNumber)
        {
            List<PhoneAddress> listPhoneAddress = new List<PhoneAddress>();
            DataTable dt = DataAccess.GetPhoneAddressByPhoneNumber(phoneNumber);
            foreach (DataRow dr in dt.Rows)
            {
                string firstName = dr["FirstName"].ToString();
                string lastName = dr["LastName"].ToString();
                string address = dr["Address"].ToString();

                listPhoneAddress.Add(new PhoneAddress(phoneNumber, firstName, lastName, address));
            }

            return listPhoneAddress;
        }

        public static List<PhoneAddress> GetAllPhoneAddress()
        {
            List<PhoneAddress> listPhoneAddress = new List<PhoneAddress>();
            DataTable dt = DataAccess.GetAllPhoneAddress();
            foreach (DataRow dr in dt.Rows)
            {
                string phoneNumber = PhoneAddress.PhoneForming(dr["PhoneNumber"].ToString()); //moi sua
                string firstName = dr["FirstName"].ToString();
                string lastName = dr["LastName"].ToString();
                string address = dr["Address"].ToString();

                listPhoneAddress.Add(new PhoneAddress(phoneNumber, firstName, lastName, address));
            }

            return listPhoneAddress;
        }
        public static List<PhoneAddress> SearchPhoneAddress(string phoneNumber, string firstName, string lastName, string address)
        {
            List<PhoneAddress> listPhoneAddress = new List<PhoneAddress>();
            DataTable dt = DataAccess.SearchPhoneAddress(phoneNumber, firstName, lastName, address);
            foreach (DataRow dr in dt.Rows)
            {
                string phoneNumber2 = PhoneAddress.PhoneForming(dr["PhoneNumber"].ToString()); //moi sua
                string firstName2 = dr["FirstName"].ToString();
                string lastName2 = dr["LastName"].ToString();
                string address2 = dr["Address"].ToString();

                listPhoneAddress.Add(new PhoneAddress(phoneNumber2, firstName2, lastName2, address2));
            }
            return listPhoneAddress;
        }

        public static void DeletePhoneAddress(string phoneNumber)
        {
            DataAccess.DeletePhoneAddress(phoneNumber.Replace(" ", ""));
        }
    }
}
