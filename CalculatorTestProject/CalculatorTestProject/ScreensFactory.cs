using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestSuite
{
    static class ScreensFactory
    {
        public static object GetScreen(string title, bool isModal = false)
        {
            object win;
            if (isModal == true)
            {
                CalculatorApp.GetBaseWindow(title);
            }
            else
            {
                CalculatorApp.GetModalWindow(title);
            }
        }
    }
}
