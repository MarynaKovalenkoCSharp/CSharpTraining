using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.ScreenObjects;
using TestStack.White.ScreenObjects.ScreenAttributes;

namespace CalculatorTestSuite
{
    public class CalculatorScreen : BaseScreen
    {
        public const string TITLE = "Calculator";

        public static bool IsModal()
        {
            return false;
        }

        public virtual MyEnum.Name Name
        {
            get
            {
                return MyEnum.Name.Calculator;
            }
        }

        public override string Title
        {
            get
            {
                return TITLE;
            }
        }

        [AutomationId("93")]
        public Button AddButton;

        [AutomationId("94")]
        public Button SubtractButton;

        [AutomationId("91")]
        public Button DivideButton;

        [AutomationId("92")]
        public Button MultiplyButton;

        [AutomationId("121")]
        public Button EqualButton;

        [AutomationId("150")]
        public Label ResultLabel;

        [AutomationId("Item 3")]
        public Menu HelpMenu;

        [AutomationId("Item 302")]
        public Menu AboutCalculatorMenu;

        public virtual void SetValue(string value)
        {
            screen.Get<Button>(value).Click();
        }

        public virtual void SetOperation(Operation operation)
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


        public CalculatorScreen(Window window, ScreenRepository screenRepository)
             : base(window, screenRepository)
        {

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
