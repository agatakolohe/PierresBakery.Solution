namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity { get; set; }
        public int BreadPrice { get; set; } = 5;

        public Bread(int breadQuantity)
        {
            BreadQuantity = breadQuantity;
        }
        public int BreadCost()
        {
            if (BreadQuantity % 3 == 0)
            {
                int breadCost = (BreadQuantity - (BreadQuantity / 3)) * BreadPrice;
                return breadCost;
            }
            else
            {
                return BreadPrice * BreadQuantity;

            }
        }

    }
    public class Pastry
    {
        public int PastryQuantity { get; set; }
        public int PastryPrice { get; set; } = 2;

        public Pastry(int pastryQuantity)
        {
            PastryQuantity = pastryQuantity;
        }

        public int PastryCost()
        {
            if (PastryQuantity % 3 == 0)
            {
                int pastryCost = (PastryQuantity / 3) * 5;
                return pastryCost;
            }
            else if (PastryQuantity % 3 > 0 && PastryQuantity > 3)
            {
                int pastryCost = ((PastryQuantity / 3) * 5) + ((PastryQuantity % 3) * 2);
                return pastryCost;
            }
            else
            {
                return PastryQuantity * PastryPrice;
            }

        }
    }
}