using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
   public class AddressDal
    {
        public void Add(Address address)
        {
            Console.WriteLine("Adres eklendi.");
        }
    }
}
