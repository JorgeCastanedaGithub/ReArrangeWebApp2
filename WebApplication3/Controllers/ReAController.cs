using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class ReAController : Controller
    {
        public IActionResult ReArrangeArrays(string[] arrayN, int[] arrayO)
        {
            string[] newArray;

            // Variables used for test
            arrayN = new string[] { "Amazon", "Apple", "Google" };
            arrayO = new int[] { 2, 3, 1 };

            ///Set the size of the array
            int k = arrayN.Length;

            ///Create the new array
            newArray = new string[k];
            try
            {
                ///Reordered the values 
                for (int j = 0; j < k; j++)
                {
                    string name = arrayN[j];
                    int order = arrayO[j];
                    newArray.SetValue(name, order - 1);
                }
            }
            catch (Exception e)
            {
                ///For this example, if something wrong happen, show the error meesagge
                newArray.SetValue(e.Message, 0);
            }

            return Ok(newArray);

        }
    }
}
