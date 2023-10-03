using System.Security.AccessControl;

namespace PasseBene
{
    public class Client
    {
        private float _argent = 0;
        private string? _name;
        private DateOnly _date;

        public Client(string name, DateOnly date, float argent = 0)
        {
            _argent = argent;
            _name = name;
            _date = date;
        }

        public float Argent
        {
            get
            {
                return _argent;
            }
            set
            {
                _argent = value;
            }
         }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public DateOnly Date
        {
            get
            {
                return _date;
            }
        }
    }
}