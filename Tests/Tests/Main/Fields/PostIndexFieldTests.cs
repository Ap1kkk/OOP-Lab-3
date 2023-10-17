using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;
using Lab4.Main.Expressions;

namespace Lab4.Main.Fields.Tests
{
    [TestClass()]
    public class PostIndexFieldTests
    {
        [TestMethod()]
        public void PostIndexFieldTest()
        {
            PostIndexField postIndexField = new PostIndexField(Utils.DefaultFirm());
            Assert.IsNotNull(postIndexField);
            var value1 = postIndexField.Value;
            var value2 = postIndexField.Value;
            Assert.AreSame(value1, value2);
        }

        [TestMethod()]
        public void CloneTest()
        {
            PostIndexField postIndexField = new PostIndexField(Utils.DefaultFirm());
            Assert.AreNotSame(postIndexField, postIndexField.Clone());
        }
    }
}