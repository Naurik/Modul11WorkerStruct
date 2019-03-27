using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerStruct
{
    public struct Worker
    {
        public string SurnameManagers { get; set; }
        public int AgeManagers { get; set; }
        public int SalaryManagers { get; set; }
        public DateTime DateBeginWorkManagers { get; set; }

        public string SurnameClerk { get; set; }
        public int AgeClerk { get; set; }
        public int SalaryClerk { get; set; }
        public DateTime DateBeginWorkClerk { get; set; }

        public string SurnameBoss { get; set; }
        public int AgeBoss { get; set; }
        public int SalaryBoss { get; set; }
        public DateTime DateBeginWorkBoss { get; set; }
    }
}
