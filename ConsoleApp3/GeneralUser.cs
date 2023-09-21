using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract public class GeneralUser : IContactable
    {
        // INCASE OF SUB CLASSES THAT ARE ONLY MEANT FOR INHERITENCE - CAN MAKE IT ABSTRACT
        // Something that can be done here, and not an interface is to add variables

        protected string _firstname;
        protected string _lastname;

        public GeneralUser(string firstname, string lastname) 
        {

            _firstname = firstname;
            _lastname = lastname;

        }

        public abstract void Contact();

    }
}
