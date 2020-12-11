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
}