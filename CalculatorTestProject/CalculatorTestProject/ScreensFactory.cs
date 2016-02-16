using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestSuite
{
    static class ScreensFactory
    {
        public static BaseScreen GetScreen(string title, Name name = Name.Calculator)
        {
            switch (name)
            {
                case Name.About:
                    return CalculatorApp.GetScreen<AboutScreen>(title);
                default:
                    return CalculatorApp.GetScreen<CalculatorScreen>(title);
            }
        }
    }
}
