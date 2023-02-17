using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLogin
{
    public class Register
    {
        public string Username { get; set; }       
        string _mobilenumber;

        public string Mobilenumber
        {
            get { return _mobilenumber; }
            set
            {
                if (value.Length == 10)
                {
                    _mobilenumber = value;
                }
                else
                { throw new Exception("Invalid mobile number length"); }
            }
        }
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        string _passcode;

        public string Passcode
        {
            get { return _passcode; }
            set
            {

                if (value.Length >= 8 && value.Length <= 15)
                {
                    _passcode = value;
                }
                else
                { throw new Exception("Invalid Password length"); }
            }
        }

        string _confirmpasscode;

        public string Confirmpasscode
        {
            get { return _confirmpasscode; }
            set
            {
                if (value.Length >= 8 && value.Length <= 15)
                {


                    _confirmpasscode = value;
                }
                else
                { throw new Exception("Invalid Password length"); }
            }
        }
       


    }
}