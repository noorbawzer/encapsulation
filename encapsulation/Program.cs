using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Noor";
            p.LastName = "Bawzer";
            p.Email = "wqaiuy@.com";
            p.Print();
        }
    }
}
