using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class EmailUser : GeneralUser
    {

        private string _emailaddress;

        public EmailUser(string firstname, string lastname, string emailadress) : base(firstname, lastname) 
        {
            _emailaddress = emailadress;
        }
        public override void Contact()
        {
            Console.WriteLine("Message by Email");
        }

        public override string ToString()
        {
            return $"{_firstname} {_lastname} | {_emailaddress}";
        }


    }
}
