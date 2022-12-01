using Bank;

namespace BankTest
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void KontoEinlaegen_mit_Eroefnungsbetrag_Nicht_Negativ()
        {
            // Arrange
            Konto erste;

            // act
            erste = new Konto(-100);

            // assert
            Assert.IsTrue(erste.Guthaben < 0);
        }
    }
}