using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    class Cat : Animal
    {
        string name;
        string wool;
        public override string Name 
        {  
            get => name;
            set => name = value;
        }

        public Cat(string name, string wool)
            : base(name)
        {
            this.wool = wool;
        }
        
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
