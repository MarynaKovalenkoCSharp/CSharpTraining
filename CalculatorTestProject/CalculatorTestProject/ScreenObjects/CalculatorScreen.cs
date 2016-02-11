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
    public class CalculatorScreen : BaseScreen
    {
        public const string TITLE = "Calculator";

        public override bool IsModal
        {
            get
            {
                return false;
            }
        }

        public override string Title
        {
            get
            {
                return TITLE;
            }
        }

        public Button OneButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("131"));
            }
        }

        public Button TwoButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("132"));
            }
        }

        public Button ThreeButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("133"));
            }
        }

        public Button AddButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("93"));
            }
        }

        public Button SubtractButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("94"));
            }
        }

        public Button DivideButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("91"));
            }
        }

        public Button MultiplyButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("92"));
            }
        }

        public Button EqualButton
        {
            get
            {
                return screen.Get<Button>(SearchCriteria.ByAutomationId("121"));
            }
        }

        public Label ResultLabel
        {
            get
            {
                return screen.Get<Label>(SearchCriteria.ByAutomationId("150"));
            }
        }

        public Menu HelpMenu
        {
            get
            {
                return screen.Get<Menu>(SearchCriteria.ByAutomationId("Item 3"));
            }
        }

        public Menu AboutCalculatorMenu
        {
            get
            {
                return screen.Get<Menu>(SearchCriteria.ByAutomationId("Item 302"));
            }
        }

        public CalculatorScreen(Window window)
            : base(window)
        {

        }

        public void SetValue(string value)
        {
            screen.Get<Button>(SearchCriteria.ByText(value)).Click();
        }

        public void SetOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    AddButton.Click();
                    break;
                case Operation.Subtract:
                    SubtractButton.Click();
                    break;
                case Operation.Multiply:
                    MultiplyButton.Click();
                    break;
                case Operation.Divide:
                    DivideButton.Click();
                    break;
            }
        }
    }

    public enum Operation
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }
}
