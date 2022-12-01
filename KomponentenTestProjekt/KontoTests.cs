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
            
            // Act
            Konto k = new Konto(startguthaben);

            // Assert
            Assert.AreEqual(startguthaben, k.Guthaben);
        }
    }
}