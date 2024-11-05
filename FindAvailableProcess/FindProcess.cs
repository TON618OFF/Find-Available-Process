using System;
using System.Collections.Generic;

namespace FindAvailableProcess
{
    public class FindProcess
    {
        public static void Main()
        {
            Console.Write("Введите название процесса: ");
            string processName = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(processName))
            {
                Console.WriteLine("Название процесса не может быть пустым!");
            }
            else
            {
                bool isRunning = IsProcessRunning(processName);

                if (isRunning)
                {
                    Console.WriteLine($"Процесс {processName} запущен.");
                }
                else
                {
                    Console.WriteLine($"Процесс {processName} не запущен.");
                }
            }
        }

        public static bool IsProcessRunning(string processName)
        {
            //FindProcessOrigin processChecker = new FindProcessOrigin();
            FindProcessStub processChecker = new FindProcessStub();
            List<string> processes = processChecker.ListOfProcesses();

            foreach (var process in processes)
            {
                if (process.Contains(processName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
