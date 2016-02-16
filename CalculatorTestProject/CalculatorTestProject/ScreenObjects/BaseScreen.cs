using TestStack.White.UIItems.WindowItems;

namespace CalculatorTestSuite
{
    abstract public class BaseScreen
    {
        public Window screen;

        public abstract string Title { get; }

        //public static bool IsModal()



        public BaseScreen(Window window)
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
