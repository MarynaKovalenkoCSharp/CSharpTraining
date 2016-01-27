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
    abstract public class BaseScreen
    {
        public Window screen;

        public abstract string Title { get; }

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
