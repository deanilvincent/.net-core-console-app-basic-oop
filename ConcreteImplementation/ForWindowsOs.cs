using test01.Interfaces;

namespace test01
{
    public class ForWindowsOs : IComputerDefinition
    {
        public string OsName()
        {
            return "Window OS";
        }
    }
}