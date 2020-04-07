using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrForm
{
    class Cars
    {
        public int id { get; set; }
        public string mark { get; set; }
        public int year { get; set; }
        public int probeg { get; set; }
        public string colour { get; set; }
        private string about { get; set; }

        public void addCar(string mark_t, int year_t, int probeg_t, string colour_t)
        {
            using (UserContext db = new UserContext())
            {
                Cars car = new Cars();
                car.mark = mark_t;
                car.year = year_t;
                car.colour = colour_t;
                car.probeg = probeg_t;
                db.Cars.Add(car);
                db.SaveChanges();
            }
        }

        public void changeParam(List<Cars> li)
        {
            using (UserContext db = new UserContext())
            {
                string i = Convert.ToString(Console.ReadLine());
                Cars ca = db.Cars
                    .Where(j => j.mark == i)
                    .FirstOrDefault();
                string o = Convert.ToString(Console.ReadLine());
                ca.mark = o;
                db.SaveChanges();
                ca.update(li);
            }
        }

        public void update(List<Cars> li)
        {
            using (UserContext db = new UserContext())
            {
                li.Clear();

                foreach (Cars car in db.Cars)
                {
                    Cars ca = new Cars();
                    ca.id = car.id;
                    ca.mark = car.mark;
                    ca.year = car.year;
                    ca.probeg = car.probeg;
                    ca.colour = car.colour;
                    li.Add(ca);
                }
            }
        }
    }
}