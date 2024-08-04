using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02OOP
{
    internal class Address : ICloneable
    {
        private string Place;
        private string Type;
        private string Discription;

        public void SetPlace(string S)
        {
            Place = S;
        }

        public void SetType(string S)
        {
            Type = S;
        }

        public void SetDiscription(string S)
        {
            Discription = S;
        }

        public string GetAddress()
        {
            return $"{Place} - {Type} - {Discription}";
        }

        public object Clone()
        {
            Address A = new Address();

            A.SetPlace(this.Place);
            A.SetType(this.Type);
            A.SetDiscription(this.Discription);

            return A;
        }
    }
}
