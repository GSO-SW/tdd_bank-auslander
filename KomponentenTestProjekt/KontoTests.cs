using Bank;

namespace KomponentenTestProjekt
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Konto_KannErstelltWerdenMitGuthaben()
        {
            
            // Arrange
            int startguthaben = 100;
            
            // act
            Konto k = new Konto(startguthaben);

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