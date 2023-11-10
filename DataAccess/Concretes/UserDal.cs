using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class UserDal
    {
        public void Add(User user)
        {

            Console.WriteLine(user.FullName + " Giriş yaptı. ");
        }

        public void Update(User user) 
        {
            user.FullName = "Cengizhan";
            Console.WriteLine(user.FullName + " olarak güncellendi");

        }
        public void Delete(User user) 
        {
            Console.WriteLine("Silindi");
        }
    }
}
