using AtataTrainingTests.PageObjects;

namespace AtataTrainingTests.Tests
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void Test_A()
        {
            Go.To<ProductsPage>()
                .PageTitle.Should.Contain("Products")
                .Products.Rows[i => i.Name == "Armchair"].DeleteUsingJsConfirm.Click()
                .SwitchToAlertBox().Accept()
                .AggregateAssert(x => x
                .Products.Rows[i => i.Name == "Armchair"].Should.Not.BePresent()
                .Products.Rows.Count.Should.Be(4));

            var totalPrice = Go.On<ProductsPage>().Products.Rows.Select(i => i.Price.Value).ToList().Sum();
            var totalAmount = Go.On<ProductsPage>().Products.Rows.Select(r => r.Amount.Value).ToList().Sum();

            Assert.Multiple(() =>
            {
                Assert.That(totalPrice, Is.EqualTo(570m), "Total Price is not correct");
                Assert.That(totalAmount, Is.EqualTo(245), "Total Amount is not correct");
            });

            Go.To<BasePage>().PageTitle.Should.Be("Atata Sample App");
        }

        [Test]
        public void VerifySuccesfullLogin()
        {
            Go.To<BasePage>().SignInTab()
                .SignInWithUser("admin@mail.com", "abc123");

            Go.To<UsersPage>().PageTitle.Should.Be("Users"); // why context window is old - BasePage
        }
    }
}
