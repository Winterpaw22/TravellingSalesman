using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Demo_TheTravelingSalesperson
{
    class Salesperson
    {



        private string _accountID;     
        private string _firstName;
        private string _lastName;
        private List<string> _citiesVisited;

        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }
        public Salesperson()
        {
            _citiesVisited = new List<string>();
        }



    }
}
