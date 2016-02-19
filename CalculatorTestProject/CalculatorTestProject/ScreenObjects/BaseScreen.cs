using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTestSuite
{
    abstract public class BaseScreen : AppScreen
    {
        public Window screen;

        public abstract string Title { get; }

        public BaseScreen(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
        {
            if (!window.Title.Equals(Title))
            {
                throw new InvalidWindowException("Window {0} is not valid for testing because {1} is expected", window.Title, Title);
            }
            else
                screen = window;
        }
    }
}
