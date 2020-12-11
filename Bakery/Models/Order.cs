namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity { get; set; }

        public Bread(int breadQuantity)
        {
            BreadQuantity = breadQuantity;
        }
        public int BreadCost()
        {
            int price = 5;
            int breadCost = price * BreadQuantity;
            return breadCost;
        }

    }
}