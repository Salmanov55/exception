using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions.Models
{
    class Hotel
    {
        private string _name;
        private Room[] _rooms=new Room[0];

        public string Name { get { return _name; } set { _name = value; } }
        public Room this[int i]
        {
            get { return _rooms[i]; }
            set { _rooms[i] = value; }
        }

    }
}
