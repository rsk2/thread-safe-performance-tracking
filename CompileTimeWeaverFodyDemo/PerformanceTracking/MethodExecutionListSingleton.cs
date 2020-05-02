using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeWeaverFodyDemo
{
    public class MethodExecutionListSingleton
    {
        private static volatile MethodExecutionListSingleton _instance;
        public List<MethodExecution> listOfMethodExecutions;
        private static object _syncLock = new object();
        private MethodExecutionListSingleton()
        {
            listOfMethodExecutions = new List<MethodExecution>();
        }
        public static MethodExecutionListSingleton GetTimers()
        {
            if (_instance != null)
                return _instance;
            else
            {
                lock(_syncLock)
                {
                    if (_instance == null)
                        _instance = new MethodExecutionListSingleton();
                }
                return _instance;
            }
        }
    }
}
