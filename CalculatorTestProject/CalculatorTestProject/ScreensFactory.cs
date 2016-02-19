using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTestSuite
{
    static class ScreensFactory
    {
        public static BaseScreen GetScreen(Window window, ScreenRepository screenRepository, MyEnum.Name name = MyEnum.Name.Calculator)
        {
            switch(name) 
            {
                default:
                    return new CalculatorScreen(window, screenRepository);
                case MyEnum.Name.About:
                    return new AboutScreen(window, screenRepository);
            }
        }
    }
}