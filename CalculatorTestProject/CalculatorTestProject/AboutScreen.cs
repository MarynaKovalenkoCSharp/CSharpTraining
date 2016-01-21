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
    public class AboutScreen : BaseScreen
    {
        public const string TITLE = "About Calculator";
        public override string Title
        {
            get
            {
                return TITLE;
            }
        }
        public Button OKBtn
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("1"));
            }
        }
        public Label VersionInformation
        {
            get
            {
                return screen.Get<Label>(SearchCriteria.ByAutomationId("13579"));
            }
        }
        public AboutScreen(Window window)
            : base(window)
        {
        }
    }
}
