using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_.Models
{
    internal record Animal
    {
        
        public  string _gender;
        private int _birthYear;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }    
        }
        public int BirthYear
        {
            get { return _birthYear; }
            set
            {
                value = DateTime.Now.Year;
                _birthYear = value;
                _birthYear = DateTime.Now.Year;


            }
        }
        
        
    }
}
