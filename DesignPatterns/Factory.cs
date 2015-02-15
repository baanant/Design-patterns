using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class Factory
    {
        public static Position Get(int typeId)
        {
            switch (typeId)
            {
                case 1:     return new QAManager();
                case 2:     return new Developer();
                case 3:     return new Salesman();
            }
            return null;
        }
    }


    public abstract class Position
    {
        public abstract int TypeID { get; }
        public string Department { get; set; }
        public abstract string PositionType { get; }
        public abstract string PositionName { get; }
    }


    internal class QAManager:Position
    {
        public override int TypeID { get { return 1; } }

        public override string PositionType { get { return "Manager"; } }

        public override string PositionName { get { return "Quality Assurance Manager"; } }

    }

    internal class Developer:Position
    {
        public override int TypeID { get { return 2; } }

        public override string PositionType { get { return "Official"; } }

        public override string PositionName { get { return "Software Developer"; } }
    }

    internal class Salesman : Position
    {

        public override int TypeID { get { return 3; } }

        public override string PositionType { get { return "Official"; } }

        public override string PositionName { get { return "Sales assistant"; } }
    }




}
