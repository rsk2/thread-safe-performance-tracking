using CompileTimeWeaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeWeaverFodyDemo
{
    public class TimeItAttribute : AdviceAttribute
    {
        public override object Advise(IInvocation invocation)
        {
            // do something before target method is Called
            // ...
            Console.WriteLine("Entering " + invocation.Method.Name);

            try
            {
                return invocation.Proceed();    // call the next advice in the "chain" of advice pipeline, or call target method
            }
            catch (Exception e)
            {
                // do something when target method throws exception
                // ...
                Console.WriteLine("TimeIt catches an exception: " + e.Message);
                throw;
            }
            finally
            {
                // do something after target method is Called
                // ...
                Console.WriteLine("Leaving " + invocation.Method.Name);
            }
        }

        public override async Task<object> AdviseAsync(IInvocation invocation)
        {
            // do something before target method is Called
            // ...
            Console.WriteLine("Entering async " + invocation.Method.Name);

            try
            {
                return await invocation.ProceedAsync().ConfigureAwait(false);   // asynchroniously call the next advice in advice pipeline, or call target method
            }
            catch (Exception e)
            {
                // do something when target method throws exception
                // ...
                Console.WriteLine("MyAdvice catches an exception: " + e.Message);
                throw;
            }
            finally
            {
                // do something after target method is Called
                // ...
                Console.WriteLine("Leaving async " + invocation.Method.Name);
            }
        }
    }

   
}
