using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Model;

namespace Framework.Services
{
    class MessageCreater
    {
        public static Message WithAllProperties()
        {
            return new Message( TestDataReader.GetData("Email"), TestDataReader.GetData("PhoneNumber"), TestDataReader.GetData("MessageText"), TestDataReader.GetData("Name")); // fields  "E-mail","Номер"
        }
        //public static Message WithoutAllProperties()
        //{
        //    return new Message("", "", " ", ""); // fields "Тема", "E-mail","Номер","Сообщение"
        //}
        public static Message WithoutAllProperties()
        {
            return new Message("", " ", " ", " "); // fields "E-mail","Номер"
        }
    }
}
