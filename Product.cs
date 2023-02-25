using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    class Product
    {
        //This class is used in AddProducts Form (Form2)

        public string productName;
        public decimal price;
        public string unit;
        public string productID;


        private char firstProductLetter;
        private char lastProductLetter;
        string digitNums;
        public string IDnum()
        {
            
            try
            {
                if (KeepValue.productName != null)
                {
                    Random random = new Random();

                    firstProductLetter = KeepValue.productName[0];
                    lastProductLetter = KeepValue.productName[KeepValue.productName.Length - 1];
                    digitNums = Convert.ToString(random.Next(1000, 10000));
                    return firstProductLetter + digitNums + lastProductLetter;
                }
                else
                {
                    return "Error";
                }

            }
            catch (IndexOutOfRangeException)
            {
                return "Error";
            }
        }
    }
}
