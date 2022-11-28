using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class OrderHistory
    {


        dynamic persons = new[] 
        { 
            new {name="jalaluddin", age=41}, 
            new {name="tareq", age=33}, 
            new {name="hasan", age=52}, 
            new {name="rashed", age=21}, 
            new{name="monir", age=45} 
        };
        dynamic orders = new[]
        {
            new{name="monir", amount=300.5},
            new{name="rashed", amount=20.5},
            new{name="tareq", amount=29.9},
            new{name="hasan", amount=17.7},
            new{name="jalaluddin", amount=30.2},

        };


        public object GetOrders()
        {
            var result = new List< object >();

            foreach (var person in persons)
            {
                foreach(var order in orders)
                {
                    if(person.name == order.name)
                    {

                        result.Add(new {person.name, order.amount});

                    }
                }
            }

            return result;
        }
    }
}
