using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool HasFeathers { get; set; }
        public bool IsWarmBlooded { get; set; }


        public Bird()
        {

        }
        
        public Bird(string name, int age, int legs, bool isAdopted, bool isWarmBlooded, bool hasFeathers, string type, int wings)
        {
            Name = name;
            Age = age;
            Legs = legs;
            IsAdopted = isAdopted;
            IsWarmBlooded = isWarmBlooded;
            Wings = wings;
            HasFeathers = hasFeathers;
            Type = type;
        }









    }
}
