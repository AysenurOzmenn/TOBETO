using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //field tanımladık.
        //public string FirstName;

        //Property tanımladık.

        public int Id { get; set; }

        /*private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }

            //Encapsulation olayı.
        }*/
        public string FirstName {  get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
