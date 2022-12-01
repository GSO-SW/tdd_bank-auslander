using Bank;
namespace KomponentenTestProjekt
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            // Arrange
            Konto erste;

            // act
            erste = new Konto(-100);

            //assert
            try
            {
                Assert.IsTrue(erste.Guthaben >= 0);
            }

            catch
            {
                Assert.Fail("Konto kann mit negativem Wert angelegt werden.");
            }






}
    }
}