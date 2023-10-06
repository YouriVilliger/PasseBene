using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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