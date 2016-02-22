using System;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using System.Reflection;
using TestStack.White.ScreenObjects;
using TestStack.White.Factory;

namespace CalculatorTestSuite
{
    class CalculatorApp
    {
        private static CalculatorApp instance;

        private static Application calcApp;

        public static Window MainWindow
        {
            get { return calcApp.GetWindow(CalculatorScreen.TITLE); }
        }
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

        public void ShutDown()
        {
            calcApp.Close();
        }
    
        public static T GetScreen<T>(string title, ScreenRepository screenRepository)
            where T : BaseScreen
        {
            Type type = typeof(T);
            MethodInfo method = type.GetMethod("IsModal", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Window window;
            if ((bool)method.Invoke(null, null))
            {
                window = MainWindow.ModalWindow(title);
            }
            else
            {
                window = MainWindow;
            };

            return (T)ScreensFactory.GetScreen(window, screenRepository, MyEnum.ParseEnum(title));
        }   
    }
}



