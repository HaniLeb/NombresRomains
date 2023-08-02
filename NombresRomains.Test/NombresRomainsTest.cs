namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Theory(DisplayName = "Etant donné le chiffre de 1 à 3" +
                            " Quand je convertis chiffreArabe en NombreRomain" +
                            " Alors j'obtiens I x fois")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUn(uint chiffreArabe)
        {
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            var iResult = new string('I', (int)chiffreArabe);

            Assert.Equal(iResult, nombreRomain);
        }

        [Fact(DisplayName = "Etant donné le chiffre 4" +
                            " Quand je convertis chiffreArabe en NombreRomain" +
                            " Alors j'obtiens IV")]
        public void TestQuatre()
        {
            const uint chiffreArabe = 4;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("IV", nombreRomain);

        }        
        
        [Theory(DisplayName = "Etant donné le chiffre de 5 à 8" +
                            " Quand je convertis chiffreArabe en NombreRomain" +
                            " Alors j'obtiens V plus x fois I")]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinq(uint chiffreArabe)
        {
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            var iResult = new string('I', (int)chiffreArabe - 5);

            Assert.Equal("V" + iResult, nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 9" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens 9")]
        public void TestNeuf()
        {
            const uint chiffreArabe = 9;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("IX", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 10" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens 10")]
        public void TestDix()
        {
            const uint chiffreArabe = 10;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("X", nombreRomain);

        }
    }
}