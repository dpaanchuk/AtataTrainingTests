﻿
namespace AtataTrainingTests
{
    [SetUpFixture]
    public sealed class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            // Find information about AtataContext configuration on https://atata.io/getting-started/#configuration
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments(
                        "start-maximized",
                        "disable-search-engine-choice-screen")
                .UseBaseUrl("https://demo.atata.io/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures();

            //new LoginPage().SignInWithUser("admin@mail.com", "abc123");

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}
