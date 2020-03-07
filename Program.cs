using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var computer = new Desktop("ASUS Computer", CaseTypeEnum.Fulltower);
            //var computer = new Laptop("MSI Laptop", LaptopTypeEnum.Netbook);
            var computer = new Server("Windows Server 2018");
  
            Console.Write($"Computer name : {computer.Name}");
            var computerNumber = computer.ComputerNumber();
            Console.Write($"Computer int : {computerNumber}");
            Console.Write($"Computer OS name : {computer.OsName()}");
            //Console.Write($"Show name : {computer.ShowName()}");
        }
    }
}
