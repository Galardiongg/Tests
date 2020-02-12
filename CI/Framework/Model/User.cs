using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public class User
    {
        public User(string email,string password,string name,string phoneNumber, string startCountry, string endCountry, string weight, string size)
        {
            this.EMail = email;
            this.Password = password;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.StartCountry = startCountry;
            this.EndCountry = endCountry;
            this.Weight = weight;
            this.Size = size;
        }

        public override string ToString()
        {
            return "\nUser data: \n" +
                "EMail: " + EMail + "\n" +            
                "Password: " + Password + "\n" +
                "Name: " + Name + "\n" +
                "PhoneNumber: " + PhoneNumber + "\n" +
                "StartCountry: " + StartCountry + "\n" +
                "EndCountry: " + EndCountry + "\n" +
                "Weight: " + Weight + "\n" +
                "Size: " + Size + "\n";
        }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string StartCountry { get; set; }
        public string EndCountry { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }

    }
}
