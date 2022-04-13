using HM3.Commands;
using HM3.Interfaces;
using HM3.Journals;
using HM3.Works;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HM3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Strategy_RepeatedAndWriteLog_NullReferebceException()
        {
            Run run = new Run();
            IRunCommand command = new RunCommand(new Mocks.RunPbjectThrowNullReferenceException());
            run.AddCommand(command);
            run.Start();

            string log = LogApp.GetMessages().Last();
            string etalon = $"{new NullReferenceException().GetType()} {new RepeatedCommand(null).GetType()}";
            Assert.AreEqual(log, etalon);
        }

        [Test]
        public void Strategy_RepeatedAndWriteLog_DivideByZeroException()
        {
            Run run = new Run();
            IRunCommand comaand = new RunCommand(new Mocks.RunPbjectThrowDivideByZeroException());
            run.AddCommand(comaand);
            run.Start();

            string log = LogApp.GetMessages().Last();
            string etalon = $"{new DivideByZeroException().GetType()} {new RepeatedCommand(null).GetType()}";
            Assert.AreEqual(log, etalon);
        }

        [Test]
        public void Strategy_TwoRepeatedAndWriteLog_ArgumentOutOfRangeException()
        {
            Run run = new Run();
            IRunCommand comaand = new RunCommand(new Mocks.RunPbjectThrowArgumentOutOfRangeException());
            run.AddCommand(comaand);
            run.Start();

            string log = LogApp.GetMessages().Last();
            string etalon = $"{new ArgumentOutOfRangeException().GetType()} {new TwoRepeatedCommand(null).GetType()}";
            Assert.AreEqual(log, etalon);
        }


    }
}