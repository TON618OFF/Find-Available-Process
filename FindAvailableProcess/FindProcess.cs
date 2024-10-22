using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FindAvailableProcess
{
    public class FindProcess
    {
        static void Main()
        {
            Console.Write("Введите название процесса: ");
            string processName = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(processName))
            {
                Console.WriteLine("Название процесса не может быть пустым!");
            }
            else
            {
                Stub stub = new Stub();
                bool isRunning = IsProcessRunning(processName, stub);

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
        public static bool IsProcessRunning(string processName, Stub stub)
        {
            List<string> stubProcesses = stub.ListOfProcesses();

            if (stubProcesses.Contains(processName))
            {
                Console.WriteLine($"Процесс {processName} найден в заглушке.");
                return true;
            }

            Console.WriteLine("Процесс не найден в заглушке.");
            return false;
        }


    }
}
