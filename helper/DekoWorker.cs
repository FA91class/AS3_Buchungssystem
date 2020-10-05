using System;

namespace AS3_Buchung.helper
{
    public static class DekoWorker
    {
        /// <summary>
        /// Writes Logo in console
        /// </summary>

        public static void SetLogo()
        {
            Console.WriteLine("Today is the " + DateTime.Now  + "\n" +
            "\n\n\nWelcome to the Buchungssystem");
        }

        public static void SetSpacer()
        {
            Console.WriteLine("=================================================================================\n");
        }

        public static void SetCommand()
        {
            Console.WriteLine("\nPlease insert a command: \n");
        }

        public static string Input()
        {
            Console.Write("$ ");
            return Console.ReadLine();
        }
    }
}
