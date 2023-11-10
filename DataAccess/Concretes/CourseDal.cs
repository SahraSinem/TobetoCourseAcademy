using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine(course.Name + " Eklendi");
        }

        public void Update(Course course)
        {
            Console.WriteLine(course.Name + " Güncellendi");
        }

        public void Delete(Course course)
        {
            Console.WriteLine(course.Name + " Silindi");
        }

    }
}
