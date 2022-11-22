using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_.Models
{
    internal record  Dog: Animal
    {
        private string _name;
         private string _breed;
       
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
         public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }
        public Dog(string name)
        {
            this._name = name;
        }
        public Dog(string name , string breed) : this(name)
        {
            this._breed = breed;
        }
        public Dog(string name, string breed,string gender): this(name,breed)
        {
            this._gender = gender;
        }
       

        
       
        
    }
}
