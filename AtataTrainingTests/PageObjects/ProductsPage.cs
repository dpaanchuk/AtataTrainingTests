using _ = AtataTrainingTests.PageObjects.ProductsPage;

namespace AtataTrainingTests.PageObjects
{
    [Url("products")]
    internal class ProductsPage : Page<_>
    {
        [FindByCss(".table")]
        public Table<ProductTableRow, _> Products { get; private set; }

        public class ProductTableRow : TableRow<_>
        {
            public Text<_> Name { get; private set; }

            [Format("C2")]
            [Atata.Culture("en-US")]
            public Currency<_> Price { get; private set; }

            public Number<_> Amount { get; private set; }

            [VerifyExists]
            [FindByXPath("(//button[text()='Delete Using JS Confirm'])[5]")]
            public Button<_> DeleteUsingJsConfirm { get; private set; }
        }
    }
}
