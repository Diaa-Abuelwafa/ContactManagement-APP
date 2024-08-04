using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02OOP
{
    internal class Email : ICloneable
    {
        private string email;
        private string Type;
        private string Discription;

        public void SetEmail(string S)
        {
            email = new string(S);
        }

        public void SetType(string S)
        {
            Type = new string(S);
        }

        public void SetDiscription(string S)
        {
            Discription = new string(S);
        }

        public string GetEmail()
        {
            return $"{email} - {Type} - {Discription}";
        }

        public object Clone()
        {
            Email E = new Email();

            E.SetEmail(this.email);
            E.SetType(this.Type);
            E.SetDiscription(this.Discription);

            return E;
        }
    }
}
