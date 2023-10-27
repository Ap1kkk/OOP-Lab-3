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

        [TestMethod()]
        public void GetFilterResultTest()
        {
            var firm1 = Utils.DefaultFirm();
            var firm2 = Utils.DefaultFirm();
            var postIndexField1 = new PostIndexField(firm1);
            var postIndexFiel2 = new PostIndexField(firm2);

            var expression1 = LogicalExpressionFactory.Create<EqualsExpression<string>, string>();
            var expression2 = LogicalExpressionFactory.Create<LessEqualsExpression<string>, string>();
            var expression3 = LogicalExpressionFactory.Create<LessExpression<string>, string>();

            Assert.IsTrue(postIndexField1.GetFilterResult(postIndexFiel2));
            postIndexField1.AddRule(expression1);
            Assert.IsTrue(postIndexField1.GetFilterResult(postIndexFiel2));
            postIndexField1.AddRule(expression2);
            Assert.IsTrue(postIndexField1.GetFilterResult(postIndexFiel2));
            postIndexField1.AddRule(expression3);
            Assert.IsFalse(postIndexField1.GetFilterResult(postIndexFiel2));
        }

        [TestMethod()]
        public void CreateRuleTest()
        {
            Firm firm = Utils.DefaultFirm();
            NameField nameField = new NameField(firm);
            NameRule rule = nameField.CreateRule<NameRule>();
            Assert.IsNotNull(rule);
            Assert.AreSame(nameField, rule.Field);
        }
    }
}