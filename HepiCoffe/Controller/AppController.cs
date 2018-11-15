using HepiCoffe.Model;
using HepiCoffe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepiCoffe.Controller
{
    class AppController
    {
        private User costumer;
        private DrinkCollection drinkCollection;

        public AppController()
        {
            this.costumer = new User();
            this.drinkCollection = new DrinkCollection();
        }

        public void addCostumer(User user)
        {
            this.costumer = user;
        }
        public User getCostumer()
        {
            return this.costumer;
        }
        public Drink getDrinkByName(String name)
        {
            return this.drinkCollection.findDrink(name);
        }

        
    }
}
