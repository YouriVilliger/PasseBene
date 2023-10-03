using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasseBene
{
    public class Article
    {
        private string _name;
        private float _price;

        public Article(string name, float price)
        {
            _name = name;
            _price = price;
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
