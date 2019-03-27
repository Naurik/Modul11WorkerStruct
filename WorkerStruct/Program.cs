using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Сколько сотрудников?(Менеджеров)");
            int countManag = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько сотрудников?(Клерков)");
            int countClerk = int.Parse(Console.ReadLine());
            Worker[] workerManag = new Worker[countManag];
            Worker[] workerClerk = new Worker[countClerk];
            Worker workerBoss = new Worker();
            for(int i=0; i<countManag; i++)
            {
                Console.WriteLine($"Введите фамилию {i + 1}-го менеджера");
                string nameM = Console.ReadLine();
                DateTime datebeginM = new DateTime(rand.Next(2000,2019), rand.Next(1,12), rand.Next(1,30));
                workerManag[i].SurnameManagers = nameM;
                workerManag[i].SalaryManagers = rand.Next(20000,70000);
                workerManag[i].AgeManagers = rand.Next(20, 45);
                workerManag[i].DateBeginWorkManagers = datebeginM;
            }
            for (int i = 0; i < countClerk; i++)
            {
                Console.WriteLine($"Введите фамилию {i + 1}-го клерка");
                string nameC = Console.ReadLine();

                DateTime datebeginC = new DateTime(rand.Next(2000, 2019), rand.Next(1, 12), rand.Next(1, 30));
                workerClerk[i].SurnameClerk = nameC;
                workerClerk[i].SalaryClerk = rand.Next(20000, 70000);
                workerClerk[i].AgeClerk = rand.Next(20, 45);
                workerClerk[i].DateBeginWorkClerk = datebeginC;
            }

            Console.WriteLine($"Введите фамилию начальника");
            string nameB = Console.ReadLine();
            DateTime datebeginB = new DateTime(rand.Next(2000, 2019), rand.Next(1, 12), rand.Next(1, 30));
            workerBoss.SurnameBoss = nameB;
            workerBoss.SalaryBoss = rand.Next(20000, 70000);
            workerBoss.AgeBoss = rand.Next(20, 45);
            workerBoss.DateBeginWorkBoss = datebeginB;
            
            Console.WriteLine("1)**************************************");
            for (int i = 0; i < countManag; i++)
            {
                Console.WriteLine($"Имя {i + 1}-го менеджера: " + workerManag[i].SurnameManagers);
                Console.WriteLine($"Зарплата {i + 1}-го менеджера: " + workerManag[i].SalaryManagers);
                Console.WriteLine($"Возраст {i + 1}-го менеджера: " + workerManag[i].AgeManagers);
                Console.WriteLine($"Дата начала работы {i + 1} менеджера: " + workerManag[i].DateBeginWorkManagers);
            }

            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < countClerk; i++)
            {
                Console.WriteLine($"Имя {i + 1}-го клерка: " + workerClerk[i].SurnameClerk);
                Console.WriteLine($"Зарплата {i + 1}-го клерка: " + workerClerk[i].SalaryClerk);
                Console.WriteLine($"Возраст {i + 1}-го клерка: " + workerClerk[i].AgeClerk);
                Console.WriteLine($"Дата начала работы {i + 1} менеджера: " + workerClerk[i].DateBeginWorkClerk);
            }

            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"Имя босса: " + workerBoss.SurnameBoss);
            Console.WriteLine($"Зарплата босса: " + workerBoss.SalaryBoss);
            Console.WriteLine($"Возраст босса: " + workerBoss.AgeBoss);
            Console.WriteLine($"Дата начала работы босса: " + workerBoss.DateBeginWorkBoss);
            Console.ReadLine();

            Console.WriteLine("2)---------------------------------------");
            int summSalaryClerk =0;
            int averageSalaryClerk = 0;
            for (int j = 0; j < countClerk; j++)
                {
                    summSalaryClerk += workerClerk[j].SalaryClerk;
                    averageSalaryClerk = (int)(summSalaryClerk /countClerk);
                }
            var result = from Worker in workerManag where Worker.SalaryManagers>averageSalaryClerk
                         orderby Worker.SurnameManagers
                         select Worker;

            foreach (Worker w in result)
            {
                Console.WriteLine($"Имя менеджера: " + w.SurnameManagers);
            }
            Console.ReadLine();


            Console.WriteLine("3)-==================================");
            for (int i = 0; i < countManag; i++)
            {
                if (workerManag[i].DateBeginWorkManagers.Year > workerBoss.DateBeginWorkBoss.Year
                || workerManag[i].DateBeginWorkManagers.Year == workerBoss.DateBeginWorkBoss.Year
                && workerManag[i].DateBeginWorkManagers.Month > workerBoss.DateBeginWorkBoss.Month
                || workerManag[i].DateBeginWorkManagers.Year == workerBoss.DateBeginWorkBoss.Year
                && workerManag[i].DateBeginWorkManagers.Month == workerBoss.DateBeginWorkBoss.Month
                && workerManag[i].DateBeginWorkManagers.Day > workerBoss.DateBeginWorkBoss.Day)
                {
                    Console.WriteLine($"Имя {i + 1}-го менеджера: " + workerManag[i].SurnameManagers);
                    Console.WriteLine($"Зарплата {i + 1}-го менеджера: " + workerManag[i].SalaryManagers);
                    Console.WriteLine($"Возраст {i + 1}-го менеджера: " + workerManag[i].AgeManagers);
                    Console.WriteLine($"Дата начала работы {i + 1} менеджера: " + workerManag[i].DateBeginWorkManagers);
                }
            }
            Console.WriteLine("+++++++++++++");
            for (int i = 0; i < countClerk; i++)
            {
                if (workerClerk[i].DateBeginWorkClerk.Year > workerBoss.DateBeginWorkBoss.Year
                || workerClerk[i].DateBeginWorkClerk.Year == workerBoss.DateBeginWorkBoss.Year
                && workerClerk[i].DateBeginWorkClerk.Month > workerBoss.DateBeginWorkBoss.Month
                || workerClerk[i].DateBeginWorkClerk.Year == workerBoss.DateBeginWorkBoss.Year
                && workerClerk[i].DateBeginWorkClerk.Month == workerBoss.DateBeginWorkBoss.Month
                && workerClerk[i].DateBeginWorkClerk.Day > workerBoss.DateBeginWorkBoss.Day)
                {
                    Console.WriteLine($"Имя {i + 1}-го клерка: " + workerClerk[i].SurnameClerk);
                    Console.WriteLine($"Зарплата {i + 1}-го клерка: " + workerClerk[i].SalaryClerk);
                    Console.WriteLine($"Возраст {i + 1}-го клерка: " + workerClerk[i].AgeClerk);
                    Console.WriteLine($"Дата начала работы {i + 1} менеджера: " + workerClerk[i].DateBeginWorkClerk);
                }
            }
            Console.ReadLine();
        }
    }
}
