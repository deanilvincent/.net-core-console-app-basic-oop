using test01.Interfaces;

namespace test01
{
    public class Laptop : Computer, IComputerDefinition
    {
        public enum LaptopTypeEnum
        {
            Notebook,
            Netbook
        }

        private readonly IComputerDefinition computerDefinition;

        public LaptopTypeEnum LaptopType { get; private set; }
        public Laptop(string name, LaptopTypeEnum laptopType) : base(name)
        {
            LaptopType = laptopType;
            computerDefinition = new ForMacOs();
        }

        public override int ComputerNumber(){
            return 30000;
        }

        public override string OsName() => computerDefinition.OsName();
    }
}