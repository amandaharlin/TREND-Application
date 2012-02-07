using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrendWinForm.MyUtilities
{
    public static class ErrorProviders
    {

        public static bool HasSomethingOtherThanNumbers(string testCase)
        {
            if (testCase == string.Empty)
            {
                return true;
            }
            char[] testArr = testCase.ToCharArray();
            bool testBool = false;
            for (int i = 0; i < testArr.Length; i++)
            {
                if (!(char.IsNumber(testArr[i]) || testArr[i].Equals('.')))
                {
                    testBool = true;
                }
            }
            return testBool;
        }

    }
}
