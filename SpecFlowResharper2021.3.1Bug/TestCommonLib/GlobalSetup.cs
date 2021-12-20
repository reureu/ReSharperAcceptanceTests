using System;
using NUnit.Framework;

using Logger = ClassLibrary1.Logger;

[SetUpFixture]
public class GlobalSetup
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        var met = System.Reflection.MethodBase.GetCurrentMethod();
        Logger.LogMethod(met);

        Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
    }
}