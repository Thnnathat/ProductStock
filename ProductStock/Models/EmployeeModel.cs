using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Models
{
   public class EmployeeModel
    {

       private string empID;
       private string password;
       private string prefix;
       private string firstName;
       private string lastName;
       private string role;
       private byte[] image;

       public string EmpID { get => empID; set => empID = value; }
       public string Password { get => password; set => password = value; }
       public string Prefix { get => prefix; set => prefix = value; }
       public string FirstName { get => firstName; set => firstName = value; }
       public string LastName { get => lastName; set => lastName = value; }
       public string Role { get => role; set => role = value; }
       public byte[] Image { get => image; set => image = value; }
    }
}
