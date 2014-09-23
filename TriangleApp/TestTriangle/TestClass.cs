using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TriangleApp;

namespace TestTriangle
{
    public class TestClass
    {
        [Test]
        public void TestToRad()
        {
            TriangleApp.Triangle tr = new TriangleApp.Triangle();
            Assert.That(tr.ToRad(0), Is.EqualTo(0));
            Assert.That(tr.ToRad(90), Is.EqualTo(1.5707963267948966192313216916398));
            Assert.That(tr.ToRad(180), Is.EqualTo(Math.PI));
        }

        [Test]
        public void TestToGrad()
        {
            TriangleApp.Triangle tr = new TriangleApp.Triangle();
            Assert.That(tr.ToGrad(0), Is.EqualTo(0));
            Assert.That(tr.ToGrad(1.5707963267948966192313216916398), Is.EqualTo(90));
            Assert.That(tr.ToGrad(Math.PI), Is.EqualTo(180));
        }
    }
}
