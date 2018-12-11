using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test__1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prim()
        {
            int n = 5;
            bool prime;
            prime = true;
            for(int i=2;i<=n/2;i++)
            {
                if (n % i == 0)
                    prime = false;
            }
            Assert.IsTrue(prime);
        }
        [TestMethod]
        public void DacaENumar()
        {
            string S = "123";
            bool numar = true;
            for (int i= 0;i<S.Length;i++)
            {
                if(!char.IsDigit(S[i]))
                {
                    numar = false;
                }
            }
            Assert.IsTrue(numar);
        }
    }
}
