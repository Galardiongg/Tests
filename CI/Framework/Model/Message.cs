using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public class Message
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PNumber { get; set; }
        public string MessageText { get; set; }
        public Message( string email, string pNumber, string message, string name)
        {
            Name = name;
            Email = email;
            PNumber = pNumber;
            MessageText = message;

        }
        public override string ToString()
        {
            return "\nMessage data:\n"+
                "Namr:" + Name + "\n"+
                "Email: " + Email +"\n" +
                "PNumber: " + PNumber +"\n" +
                "MessageText: " + MessageText + "\n";
        }
    }
}
