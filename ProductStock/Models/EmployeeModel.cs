using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Models
{
   public class EmployeeModel
    {

        public EmployeeModel()
        {

        }
        public EmployeeModel(string empID, string password, string prefix, string firstName, string lastName, string role, string image)
        {
            EmpID = empID;
            Password = password;
            Prefix = prefix;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Image = image;
        }

       private string empID;
       private string password;
       private string prefix;
       private string firstName;
       private string lastName;
       private string role;
       private string image;

        public string EmpID { get => empID; set => empID = value; }
        public string Password { get => password; set => password = value; }
        public string Prefix { get => prefix; set => prefix = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Role { get => role; set => role = value; }
        public string Image { get => image; set => image = value; }
    }
}
