using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasseBene
{
    public class Checkout
    {
        private List<Article> _articles;
        private float _balance;

        public float Balance
        {
            get
            {
                return _balance;
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
    }
}
