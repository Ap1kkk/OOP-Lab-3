﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions.Tests
{
    [TestClass()]
    public class LogicalExpressionFactoryTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            var expression = LogicalExpressionFactory.Create<EqualsExpression<int>, int>();
            Assert.IsNotNull(expression);
        }
    }
}