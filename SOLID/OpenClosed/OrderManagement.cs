using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public abstract class CardType
    {
        public abstract decimal GetDiscount(decimal price);
      
    }

    public class Standard : CardType
    {
        public override decimal GetDiscount(decimal price)
        {
            return price * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal GetDiscount(decimal price)
        {
            return price * .90m;
        }
    }

    public class Gold : CardType
    {
        public override decimal GetDiscount(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscount(decimal price)
        {
            return price * .80m;
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal price)
        {
            //var result = 0.0M;
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        result = price * .95m;
            //        break;
            //    case CardType.Silver:
            //        result = price * .9m;

            //        break;
            //    case CardType.Gold:
            //        result = price * .85m;
            //        break;
            //    case CardType.Premium:
            //        result = price * .8m;
            //        break;
            //    default:
            //        break;
            //}

            return Customer.Card.GetDiscount(price);
        }
    }
}
