using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.ScreenObjects;
using TestStack.White.ScreenObjects.ScreenAttributes;

namespace CalculatorTestSuite
{
    public class AboutScreen : BaseScreen
    {
        public const string TITLE = "About Calculator";

        public static bool IsModal()
        {
            return true;
        }
        
        public virtual MyEnum.Name Name
        {
            get
            {
                return MyEnum.Name.About;
            }
        }

        public override string Title
        {
            get
            {
                return TITLE;
            }
        }

        [AutomationId("1")]
        public Button OKBtn;
            /*
        {
            get
            { return screen.Get<Button>(SearchCriteria.ByAutomationId("1")); }
        }
        */

        [AutomationId("13579")]
        public Label VersionInformation;

        public AboutScreen(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
        }
    }
}
