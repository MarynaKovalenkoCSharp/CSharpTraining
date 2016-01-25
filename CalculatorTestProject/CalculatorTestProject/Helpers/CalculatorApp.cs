using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using Xunit.Sdk;
using Xunit.Extensions;
using TestStack.White.UIItems.WindowStripControls;

namespace CalculatorTestSuite
{
    class CalculatorApp
    {
        private static CalculatorApp instance;
        private static Application calcApp;

        protected CalculatorApp()
        {
        }

        public static CalculatorApp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalculatorApp();
                }
                return instance;
            }
        }

        public Application LaunchApp()
        {
            calcApp = Application.Launch(@"C:\Windows\System32\calc.exe");
            return calcApp;
        }

        public void ShutDownApp()
        {
            calcApp.Close();
        }
    }
}
