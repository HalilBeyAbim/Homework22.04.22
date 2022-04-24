using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork22._04._22
{
    class User
    {
        private string _username;
        private string _password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        //public string GetInfo()
        //{
        //    return $"Username: {Username} Password: {Password} IsSuper: {true} Section: {}";
        //}

        public string Username
        { 
            get
            {
                return _username;
            }
            set 
            {
                if (value.Length>6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username en azi 6 xarakter olmalidir");
                }
            }
        }
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("kodunuz minimum 8 xarakterinizden ibaret olmalidir");
                }
            }
        }
        public User()
        {

        }
        public bool CheckPassword(string password)
        {
            bool isDigit = false;
            bool IsUpper = false;
            bool IsLower = false;
            if (password.Length>8)
            {
                foreach  (char letter in password)
                {
                    if (char.IsDigit(letter))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                        IsUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        IsLower = true;
                    }
                }
                bool result = isDigit && IsUpper && IsLower;
                return result;
            }
            return false;
        }
    }
}
