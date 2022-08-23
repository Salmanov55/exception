using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions.Models
{
    class Room
    {
        private int id;
        private string _name;
        private float _price;
        private int _personCapacity;
        private bool IsAvailable = true;
        private int _id = 0;
        public int Id
        {
            get { return _id; }
           
        }
        public string Name { get; set; }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value>
                    0) ;
                _price = value;
            }
        }
        public int PersonCapacity
        {
            get { return _personCapacity; }
            set
            {
                if (value> 0) ;
                _personCapacity = value;
            }
        }

        public Room(int id, string name, int price, int personCapacity, bool isAvailable, int Id)
        {
            _id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public string ShowInfo()
        {
            return ("Room name: " + Name + "\nRoom price: " + Price + "\nRoom person capacity: " + PersonCapacity + "\nRoom is aviable: " + IsAvailable);
        }
        public Room()
        {
            _id++;
            _id = id;
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
