using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5f, 2f, "+");
            Assert.AreEqual(result, 7f);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5f, 2f, "+");
            Assert.AreEqual(result, 7f);
        }


        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5f, 2f, "-");
            Assert.AreEqual(result, 3f);
        }

        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(5f, 2f, "-");
            Assert.AreEqual(result, 3f);
        }
        

        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(5f, 2f, "*");
            Assert.AreEqual(result, 10f);
        }

        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            yield return null;

            result = Calculator.CalculatePair(5f, 2f, "*");
            Assert.AreEqual(result, 10f);
        }
        
        
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(5f, 2f, "/");
            Assert.AreEqual(result, 2.5f);
        }

        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(5f, 2f, "/");
            Assert.AreEqual(result, 2.5f);
        }
        
        
        [Test]
        public void TestSquareRoot()
        {
            result = Calculator.CalculatePair(25f, 2f, "√");
            Assert.AreEqual(result, 5f);
        }

        [UnityTest]
        public IEnumerator TestUnitySquareRoot()
        {
            yield return null;

            result = Calculator.CalculatePair(25f, 2f, "√");
            Assert.AreEqual(result, 5f);
        }
        
        
        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(5f, 2f, "^");
            Assert.AreEqual(result, 25f);
        }

        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            yield return null;

            result = Calculator.CalculatePair(5f, 2f, "^");
            Assert.AreEqual(result, 25f);
        }
    }
}
