using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24_Encapsulation
{
    internal class User
    {

        public string Username { get; set; }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }


            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 8)
                {
                    Console.WriteLine("Duzgun sifre daxil edin");
                }
                else if(!Uppercase(value))
                {
                    Console.WriteLine("en az bir boyuk herf olmalidi:");
                }

                else if (!ContainsDigit(value))
                {
                    Console.WriteLine("en az bir reqem olmalidi");
                }
                else
                {
                    _password=value;
                }

            }
        }




        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {

                if (value > 0)
                {
                    value = _age;
                }
                else
                {
                    Console.WriteLine("yas menfi ola bilmez");
                }
            }
        }



        private static bool Uppercase(string text)
        {


            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
                

            }
            return false;
        }

        private static bool ContainsDigit(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true; 
                }

            }
            return false; 
        }
    }
}