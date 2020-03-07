using test01.Interfaces;

namespace test01
{
    public class ForMacOs : IComputerDefinition
    {
        public string OsName()
        {
            return "Mac";
        }
    }
}