namespace Bakery.Models
{
    public class Bread
    {
        public int BreadQuantity { get; set; }
        public int BreadPrice { get; set; } = 5;
        public string BreadKind { get; set; }

        public Bread(int breadQuantity, string breadKind)
        {
            BreadQuantity = breadQuantity;
            BreadKind = breadKind;
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
        public string BreadType()
        {
            bool pumpernickle = BreadKind == "pumpernickle";
            string sourDough = "sourdough";
            if (pumpernickle)
            {
                return BreadKind;
            }
            else
            {
                return sourDough;
            }
        }

    }
}