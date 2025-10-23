using _ = AtataTrainingTests.PageObjects.LoginPage;
using __ = AtataTrainingTests.PageObjects.UsersPage;


namespace AtataTrainingTests.PageObjects
{
    [Url("signin")]
    [WaitForDocumentReadyState]
    internal class LoginPage : Page<_>
    {
        public TextInput<_> Email { get; private set; }

        public PasswordInput<_> Password { get; private set; }

        [FindByXPath("//button[text()='Sign In']")]
        public ButtonDelegate<__ ,_> SignInBtn { get; private set; }

        public __ SignInWithUser(string email, string password)
        {
            return Email.Set(email)
                .Password.Set(password)
                .SignInBtn.ClickAndGo();
        }
    }
}
