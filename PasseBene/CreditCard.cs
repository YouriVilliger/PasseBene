using System.Security.AccessControl;

namespace PasseBene
{
    public class CreditCard
    {
        private float _availableBalance;

        public float AvailableBalance
        {
            get
            {
                return _availableBalance;
            }
        }
    }
}