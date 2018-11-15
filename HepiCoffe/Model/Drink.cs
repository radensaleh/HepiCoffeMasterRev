using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepiCoffe.Model
{
    class Drink
    {
        private String title;
        private Double price;

        public Drink(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public String getTitle()
        {
            return this.title;
        }

        public Double getPrice()
        {
            return this.price;
        }
    }
}
