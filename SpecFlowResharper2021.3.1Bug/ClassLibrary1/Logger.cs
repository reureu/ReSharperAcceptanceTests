using System;
using System.Reflection;

namespace ClassLibrary1
{
    public static class Logger
    {
        public static void LogMethod(MethodBase method)
        {
            var tmp = $"*************************** {method.DeclaringType}.{method.Name}";
            System.Diagnostics.Trace.WriteLine(tmp);
            Console.WriteLine(tmp);
        }
    }
}
