﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._1
{
    class Address
    {
        private string  country, city, street;
        private int index, house, apartment;

        
        public string Country 
        {
            get { return country; }
            set { country = value; }
        }
        public string City 
        {
            get { return city; }
            set { city = value; }
        }
        public string Street 
        {
            get { return street; }
            set { street = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public int House 
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartament 
        {
            get { return apartment; }
            set { apartment = value; }
        }


    }
}
