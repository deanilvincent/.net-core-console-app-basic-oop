using System;

namespace test01
{
    public class Computer
    {
        private string name { get; set; }

        // constructor
        public Computer(string name)
        {
            this.name = name;
        }

        // full property
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public virtual int ComputerNumber()
        {
            return 234234;
        }

        public virtual string OsName()
        {
            return "Windows";
        }
    }
}