using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager
    {
        public void Add(User user) 
        {
            UserDal userDal = new UserDal();    
            userDal.Add(user);
        }
        public void Update(User user)
        {
            UserDal userDal = new UserDal();
            userDal.Update(user);
        }

        public void Delete(User user) 
        {
            UserDal userDal = new UserDal();
            userDal.Delete(user);
        }
    }
}
