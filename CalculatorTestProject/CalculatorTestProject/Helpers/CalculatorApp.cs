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
using System.Reflection;

namespace CalculatorTestSuite
{
    class CalculatorApp
    {
        private static CalculatorApp instance;
        private static Application calcApp;
        private const string PATH = @"C:\Windows\System32\calc1.exe";

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
            calcApp = Application.Launch(PATH);
            return calcApp;
        }

        public void ShutDownApp()
        {
            calcApp.Close();
        }

        public static T GetScreen<T>(string title)
            where T : BaseScreen
        {
            Type type = typeof(T);
            MethodInfo method = type.GetMethod("IsModal", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            //object classInstance = Activator.CreateInstance(type, null);

            if ((bool)method.Invoke(null, null))
            {
                return new AboutScreen(calcApp.GetWindow("Calculator").ModalWindow(title)) as T;
            }
            else
            {
                return new CalculatorScreen(calcApp.GetWindow(title)) as T; 
            };
        }
    }
}



