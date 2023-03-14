using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_PorjOO
{
    internal abstract class Person
    {
        string name;
        DateTime BirthDate;

        public void setName(string name)
        {
            this.name = name; 
        }

        /*public void PurchaseParkingPass()
        {

        }*/
    }
}
