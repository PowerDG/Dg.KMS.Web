namespace InitModule.Cash
{
    internal class CashRebate : BaseCash, ICash
    {
        private decimal rebate { get; set; }

        public decimal money { get; set; }
        public CashRebate(decimal v)
        {
            //this.Rebate = rebate
            this.rebate = v;
        }
        //void CashRebate(decimal rebate) {
        //}
        //calculate(money) { return money * reabte}

        public decimal calculate(decimal money)
        {
            return money * rebate;
        }

        //decimal ICash.calculate(decimal money)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}