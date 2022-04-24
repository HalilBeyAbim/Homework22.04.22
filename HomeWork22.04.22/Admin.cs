using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork22._04._22
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(string usernamem, string password, bool superAdmin, string section) : base(usernamem, password)
        {
            IsSuperAdmin = superAdmin;
            Section = section;
            
        }
        public string GetInfo()
        {
            return $"Userame: {Username}, Password: {Password}, IsSuper: {IsSuperAdmin}, Section: {Section}";
        }

    }
}
