using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services
{
    public class UserCreater
    {
        public static User RegisteredUser()
        {
            return new User(TestDataReader.GetData("User.EMail"), TestDataReader.GetData("User.Password"), TestDataReader.GetData("User.Name"), TestDataReader.GetData("User.PhoneNumber"), TestDataReader.GetData("User.StartCountry"), TestDataReader.GetData("User.EndCountry"), TestDataReader.GetData("User.Weight"), TestDataReader.GetData("User.Size"));
        }
        public static User IncorrectEmailRegisteredUser()
        {
            return new User(TestDataReader.GetData("User.EMail.Incorrect"), TestDataReader.GetData("User.Password"), TestDataReader.GetData("User.Name"), TestDataReader.GetData("User.PhoneNumber"), TestDataReader.GetData("User.StartCountry"), TestDataReader.GetData("User.EndCountry"), TestDataReader.GetData("User.Weight"), TestDataReader.GetData("User.Size"));
        }
        public static User IncorrectPhoneRegisteredUser()
        {
            return new User(TestDataReader.GetData("User.EMail"), TestDataReader.GetData("User.Password"), TestDataReader.GetData("User.Name"), TestDataReader.GetData("User.PhoneNumber.Incorrect"), TestDataReader.GetData("User.StartCountry"), TestDataReader.GetData("User.EndCountry"), TestDataReader.GetData("User.Weight"), TestDataReader.GetData("User.Size"));
        }
    }
}
