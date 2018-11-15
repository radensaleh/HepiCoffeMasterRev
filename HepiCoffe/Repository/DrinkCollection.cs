using HepiCoffe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepiCoffe.Repository 
{
    class DrinkCollection
    {
        private List<Drink> collection;

        public DrinkCollection()
        {
            this.collection = new List<Drink>();
            generateCollection();
        }

        private void generateCollection()
        {
            this.collection.Add(new Drink("Cappucino", 25000));
            this.collection.Add(new Drink("Americano", 23000));
            this.collection.Add(new Drink("Ice Tea", 20000));
            this.collection.Add(new Drink("Thai Tea", 18000));
            this.collection.Add(new Drink("Coffe Late", 25000));
            this.collection.Add(new Drink("Chocolatos", 10000));
        }

        public List<Drink> getCollection()
        {
            return this.collection;
        }

        public Drink findDrink(String title)
        {
            foreach(Drink drink in collection)
            {
                if (drink.getTitle().Equals(title))
                {
                    return drink;
                }
            }
            return null;
        }
    }
}
