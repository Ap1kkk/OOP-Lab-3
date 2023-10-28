using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Tests;
using Lab_3;
using Lab4.Main.Rules;

namespace Lab4.Main.Tests
{
    [TestClass()]
    public class FieldTests
    {
        [TestMethod()]
        public void RemoveRuleTest()
        {
            var postIndexField = new PostIndexField(Utils.DefaultFirm());
            var expression1 = LogicalExpressionFactory.Create<EqualsExpression<string>, string>();
            var expression2 = LogicalExpressionFactory.Create<EqualsExpression<string>, string>();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                postIndexField.RemoveRule(expression2);

            });

            postIndexField.AddRule(expression1);
            postIndexField.RemoveRule(expression2);
        }

    }
}