namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity { get; set; }
        public int BreadPrice { get; set; } = 5;
        public string BreadType { get; set; }

        public Bread(int breadQuantity, string breadType)
        {
            BreadQuantity = breadQuantity;
            BreadType = breadType;
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
        public string GetBreadType()
        {
            if (BreadType == "rye")
            {
                string rye = "rye";
                return rye;
            }
            else
            {
                return "nothing";
            }

        }
    }
}