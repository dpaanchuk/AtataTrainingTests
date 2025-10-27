using _= AtataTrainingTests.PageObjects.UsersPage;

namespace AtataTrainingTests.PageObjects
{
    [Url("users")]
    internal class UsersPage : Page<_>
    {
        [WaitSeconds(2)]
        public H1<_> Header { get; private set; }
    }
}
