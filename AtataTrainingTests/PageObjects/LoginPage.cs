using _ = AtataTrainingTests.PageObjects.LoginPage;

namespace AtataTrainingTests.PageObjects
{
    [Url("signin")]
    [WaitForDocumentReadyState]
    internal class LoginPage : Page<_>
    {
        public TextInput<_> Email { get; private set; }

        public PasswordInput<_> Password { get; private set; }

        [FindByXPath("//button[text()='Sign In']")]
        public ButtonDelegate<UsersPage ,_> SignInBtn { get; private set; }

        public UsersPage SignInWithUser(string email, string password)
        {
            return Email.Set(email)
                .Password.Set(password)
                .SignInBtn.ClickAndGo();
        }
    }
}
