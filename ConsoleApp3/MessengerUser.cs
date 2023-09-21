using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MessengerUser : GeneralUser
    {
        public MessengerUser(string firstname, string lastname) : base(firstname, lastname) 
        {
            
        }
        public override void Contact()
        {
            Console.WriteLine("Sending message by messenger");
        } 

    }
}
