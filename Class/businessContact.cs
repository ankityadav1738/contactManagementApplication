using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactManagementApplication.Class
{
    class businessContact : personalContact
    {
       private string businessName { get; set; }
       private string employeeName { get; set; }
       private string businessEmail { get; set; }
        private string companyAddress { get; set; }
        private string businessPhoneNum { get; set; }
        private string postCode { get; set; }

        public businessContact()
        {
            // emptey constructor
        }
        public businessContact(int id, string name, string postCode,DateTime dob,string email, string phoneNumber,string address,string BusinessName, string EmployeeName, string BusinessEmail, string BusinessPhoneNum, string CompanyAddress, string PostCode) :base(id, name, postCode, dob, email, phoneNumber, address)
        {
            this.businessName = BusinessName;
            this.employeeName = EmployeeName;
            this.businessEmail = BusinessEmail;
            this.businessPhoneNum = BusinessPhoneNum;
            this.companyAddress = CompanyAddress;
            this.postCode = PostCode;
        }
    }
}
