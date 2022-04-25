using System;

namespace HomeWork22._04._22
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();

            string username;
             
            do
            {
                Console.WriteLine("Nickname'i daxil edin");
                username = Console.ReadLine();
            } while (username.Length<=6);
            string password;
            do
            {
                Console.WriteLine("sifrenizi daxil edin");
                password = Console.ReadLine();
            } while (!user.CheckPassword(password));

            Console.WriteLine("Siz super adminsiz?");
            string SuperAdmin = Console.ReadLine();
            bool isSuper = false;

            if (SuperAdmin.ToLower() == "beli")
            {
                isSuper = true;
                Console.WriteLine("forstanmayin:)\n");
            }
            else if(SuperAdmin.ToLower() == "xeyir")
            {
                isSuper = false;
                Console.WriteLine("eybi yo:)");
            }
            Console.WriteLine("Nesiz?");
            string section = Console.ReadLine();

            Admin admin = new Admin(username, password,isSuper , section);

            Console.WriteLine(admin.GetInfo());
        }
    }
}
