using AtataTrainingTests.PageObjects;

namespace AtataTrainingTests.Tests
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void RemoveProductAndVerifyTotalRowValues()
        {
            var testData = new
            {
                products = "Products",
                armchair = "Armchair"
            };

            var productsPage = Go.To<ProductsPage>()
                .PageTitle.Should.Contain(testData.products)
                .Products.Rows[i => i.Name == testData.armchair].DeleteUsingJsConfirm.Click()
                .SwitchToAlertBox().Accept()
                .AggregateAssert(x => x
                    .Products.Rows[i => i.Name == testData.armchair].Should.Not.BePresent()
                    .Products.Rows.Count.Should.Be(4));

            productsPage.Products.Rows.Select(i => i.Price.Value).ToList().Sum().ToSutSubject().Should.Equal(570m);
            productsPage.Products.Rows.Select(r => r.Amount.Value).ToList().Sum().ToSutSubject().Should.Be(245);
        }

        [Test]
        public void VerifySuccessfulLogin()
        {
            var testData = new
            {
                header = "Users"
            };

            Go.To<UsersPage>().Header.Should.Equal(testData.header);
        }
    }
}
