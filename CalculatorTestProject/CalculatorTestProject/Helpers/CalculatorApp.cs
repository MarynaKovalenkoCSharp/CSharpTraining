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

        private CalculatorApp()
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
            //TODO: move path to config file (manager)
            calcApp = Application.Launch(@"C:\Windows\System32\calc.exe");
            return calcApp;
        }

        public void ShutDownApp()
        {
            calcApp.Close();
        }

        public static T GetCalcWindow<T>(string title) 
            where T : BaseScreen
            //TODO: create property isModal in BaseScreen. By default it should be set to FALSE in constructor. Pass it with title as parameter and return corresponding screen.
            //TODO: modal window should get parent window as parameter
        {
            switch (title)
            {
                default:
                    throw new InvalidWindowException();
                case "Calculator":
                    return new CalculatorScreen(calcApp.GetWindow(title)) as T;
                case "About Calculator":
                    return new AboutScreen(calcApp.GetWindow("Calculator").ModalWindow(title)) as T;
            };
            //TODO: custom UI item; 
            //TODO: create factory for screens
            //TODO: read about screen repository
        }
    }
}
