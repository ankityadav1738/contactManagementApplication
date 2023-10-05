using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactManagementApplication.Class
{
    class personalContact
    {
        private int id { get; set; }
        private string name { get; set; }
        private string postCode { get; set; }
        private DateTime dob { get; set; }
        private string email { get; set; }
        private string phoneNumber { get; set; }
        private string address { get; set; }
        public personalContact()
        {
            // empty constructor
        }
        public personalContact(int ID, string Name, string PostCode, DateTime DOB, string Email, string PhoneNumber, string Address)
        {
            this.id = ID;
            this.name = Name;
            this.postCode = PostCode;
            this.dob = DOB;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.address = Address;
        }
        public void setID(int ID)
        {
            this.id = ID;
        }
        public int getID()
        {
            return id;
        }
        public void setName(string Name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void getPostCode(string PostCode)
        {
            this.postCode = PostCode;
        }
        public string setPostCode()
        {
            return postCode;
        }
    }
}
