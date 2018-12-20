﻿using System;
using MyNUnit.Attributes;
using System.Threading;

namespace ClassLibrary2
{
    public class Class1
    {
        public int t = 0;

        [BeforeClass]
        public void BeforeClassMethod()
        {
            t = 10;
        }

        [Test]
        public void TrueTest()
        {
            if (t != 10)
            {
                throw new Exception();
            }
        }

        [AfterClass]
        public void AfterClassMethod()
        {
            t = 0;
        }
    }
}