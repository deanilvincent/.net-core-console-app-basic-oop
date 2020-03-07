using test01.Interfaces;

namespace test01
{
    public class Server : Computer
    {
        private readonly IComputerDefinition computerDefinition;
        public Server(string name) : base(name)
        {
            computerDefinition = new ForWindowsOs();
        }

        public override string OsName() => computerDefinition.OsName();
    }
}