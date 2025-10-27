using _ = AtataTrainingTests.PageObjects.BasePage;

namespace AtataTrainingTests.PageObjects
{
    [Url("https://demo.atata.io/")]
    internal class BasePage : Page<_>
    {
        [FindByXPath("//a[@id='sign-in']")]
        public ClickableDelegate<LoginPage, _> SignInTab { get; private set; }

        public Button<_> SignUp { get; private set; }
    }
}
