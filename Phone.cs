using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02OOP
{
    internal class Phone : ICloneable
    {
        private long phone;
        private string Type;
        private string Discription;

        public void SetPhone(long phonenumber)
        {
            phone = phonenumber;
        }

        public void SetType(string S)
        {
            Type = new string(S);
        }

        public void SetDiscription(string S)
        {
            Discription = new string(S);
        }



        public long GetPhoneNumber()
        {
            return phone;
        }

        public object Clone()
        {
            Phone E = new Phone();

            E.SetPhone(this.phone);
            E.SetType(this.Type);
            E.SetDiscription(this.Discription);

            return E;
        }
    }
}
