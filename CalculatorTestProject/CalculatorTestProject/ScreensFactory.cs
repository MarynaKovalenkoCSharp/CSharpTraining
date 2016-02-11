using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestSuite
{
    static class ScreensFactory
    {
        public static BaseScreen GetScreen(string title, bool isModal = false)
        {
            switch (isModal)
            {
                case true:
                    return CalculatorApp.GetCalcWindow<AboutScreen>(title);
                default:
                    return CalculatorApp.GetCalcWindow<CalculatorScreen>(title);
            }
        }
    }
}
