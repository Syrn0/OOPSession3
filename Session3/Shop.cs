namespace Session03
{
    public class Shop
    {
        public bool Sell(Player buyer, Weapon w, int price)
        {
            if (buyer.TrySpendGold(price))
            {
                buyer.Equip(w);
                return true;
            }
            return false;
        }
    }
}
