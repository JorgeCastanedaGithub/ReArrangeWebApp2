using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodReArrange()
        {
            ///Variables used for test
            string[] arrayN = new string[] { "Amazon", "Apple", "Google" };
            int[] arrayO = new int[] { 2, 3, 1 };

            ///Set the size of the array
            int k = arrayN.Length;

            ///Create the new array
            string[] newArray = newArray = new string[k];

            //Call the WebApi
            WebApplication3.Controllers.ReAController rea = new WebApplication3.Controllers.ReAController();
            newArray = rea.ReArrangeArrays(arrayN, arrayO);
        }
    }
}
