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