namespace InitModule.Cash
{
    public class CashNormal : BaseCash, ICash
    {
        public CashNormal()
        {

        }
        public decimal calculate(decimal money)
        {
            return money;
        }
    }
}