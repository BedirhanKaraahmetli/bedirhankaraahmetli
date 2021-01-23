using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplicate(houseCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, houseCreditManager, vehicleCreditManager };

            //applicationManager.MakeCreditPreNotification(credits);
        }
    }
}
