using System;
using DesignPatterns;

namespace Tester
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            ///This is a test for Factory design pattern.
            Console.WriteLine("Let's test our factory class:");
            for (int i = 1; i <= 3; i++)
            {
                var position = Factory.Get(i);
                Console.WriteLine("The position with type id: "
                    + position.TypeID.ToString() + ", is "
                    + position.PositionType.ToString() + " position. The name of the position is "
                    + position.PositionName.ToString() + ".");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            ///This is a test for Singleton design pattern.
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Console.WriteLine("Let's test our singleton class:");
            if (s1 == s2) Console.WriteLine("If you see this text, it means that the singleton works and the two instances s1 and s2 are the same.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
