using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeWeaverFodyDemo
{
    public class MethodExecution
    {
        public string MethodName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long ExecutionTime { get; set; }
    }
}
