using test01.Interfaces;

namespace test01
{
    public class Desktop : Computer
    {
        public enum CaseTypeEnum
        {
            Minitower,
            Fulltower
        }

        private readonly IComputerDefinition computerDefinition;
        public CaseTypeEnum CaseType { get; private set; }

        public Desktop(string name, CaseTypeEnum caseType) : base(name)
        {
            base.Name = name;
            CaseType = caseType;
            computerDefinition = new ForMacOs();
        }

        public override int ComputerNumber()
        {
            return 111111;
        }

        public string ShowName()
        {
            return Name;
        }

        public override string OsName() => computerDefinition.OsName();
    }
}