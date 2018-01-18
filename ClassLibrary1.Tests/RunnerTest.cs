using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NSubstitute;

namespace ClassLibrary1
{
    [TestClass]
    public class RunnerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region setup mock
            var class1 = Substitute.For<Class1Wrapper>();
            class1.Say().Returns("I am Substitute.");
            #endregion

            var runner = new Runner();

            var actual = runner.Run(class1);

            // Check.That(class1.Say()).IsEqualTo("I am Substitute.");
            // ^^^ Success!

            Check.That(actual).IsEqualTo("I am Substitute."); 
            // ^^^ Fail!!
            // the actual will be 'I am Class1.'
        }
    }
}
