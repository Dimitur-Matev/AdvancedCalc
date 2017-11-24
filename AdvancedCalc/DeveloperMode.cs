using System;

namespace AdvancedCalc
{
    static class DeveloperMode
    {
        private static bool isOn = true;
        public static void Print(string message)
        {
            if(isOn)
                Console.WriteLine(message);
        }
    }
}
