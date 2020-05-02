using System;
using System.Threading.Tasks;

namespace CompileTimeWeaverFodyDemo
{
    class Program
    {
        static void Main(string[] args)
        {          
            Task task1 = Task.Factory.StartNew(() => SleepAndThrowException());
            Task task2 = Task.Factory.StartNew(() => Loop50k10kTimes());
            Task task3 = Task.Factory.StartNew(() => CreateAStringOfMaxInt16Size());
            Task task4 = Task.Factory.StartNew(() => SleepAndThrowException());
            Task task5 = Task.Factory.StartNew(() => Loop50k10kTimes());
            Task task6 = Task.Factory.StartNew(() => CreateAStringOfMaxInt16Size());
            Task task7 = Task.Factory.StartNew(() => SleepAndThrowException());
            Task task8 = Task.Factory.StartNew(() => Loop50k10kTimes());
            Task task9 = Task.Factory.StartNew(() => CreateAStringOfMaxInt16Size());
            Task task10 = Task.Factory.StartNew(() => SleepAndThrowException());
            Task task11 = Task.Factory.StartNew(() => Loop50k10kTimes());
            Task task12 = Task.Factory.StartNew(() => CreateAStringOfMaxInt16Size());
            Task.WaitAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10);
            PrintTimers();
            Console.ReadLine();
        }
        static void PrintTimers()
        {
            //Here we are printing the data but it also can be saved into a persistent storage
            var timers = MethodExecutionListSingleton.GetTimers();
            foreach(var methodExecution in timers.listOfMethodExecutions)
            {
                Console.WriteLine($"Method name:{methodExecution.MethodName}, " +
                    $"Execution time: {methodExecution.ExecutionTime}," + 
                    $"Start time: {methodExecution.StartTime:hh.mm.ss.ffffff}," +
                      $"End time: {methodExecution.EndTime:hh.mm.ss.ffffff}" );
            }
        }

        [TimeIt]
        private static void SleepAndThrowException()
        {
            System.Threading.Thread.Sleep(5000);
            try
            {
                throw new NullReferenceException();
            }
            catch(Exception)
            {
                //Do nothing
            }
        }

        [TimeIt]
        public static void Loop50k10kTimes()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 50000; j++)
                { }
            }
        }

        [TimeIt]
        public static void CreateAStringOfMaxInt16Size()
        {
            String result = "";
            for (int i = 0; i <= Int16.MaxValue; i++)
            {
                result += "a";
            }
        }

    }
}
