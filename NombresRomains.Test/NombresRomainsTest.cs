namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Fact(DisplayName = "Etant donné le chiffre 1" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens I")]
        public void TestUn()
        {
            const uint chiffreArabe = 1;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("I", nombreRomain);
        }

        [Fact(DisplayName = "Etant donné le chiffre 2" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens II")]
        public void TestDeux()
        {
            const uint chiffreArabe = 2;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("II", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 3" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens III")]
        public void TestTrois()
        {
            const uint chiffreArabe = 3;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("III", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 4" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens IV")]
        public void TestQuatre()
        {
            const uint chiffreArabe = 4;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("IV", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 5" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens V")]
        public void TestCinq()
        {
            const uint chiffreArabe = 5;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("V", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 6" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens 6")]
        public void TestSix()
        {
            const uint chiffreArabe = 6;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("VI", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 7" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens 7")]
        public void TestSept()
        {
            const uint chiffreArabe = 7;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("VII", nombreRomain);

        }        
        
        [Fact(DisplayName = "Etant donné le chiffre 8" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens 8")]
        public void TestHuit()
        {
            const uint chiffreArabe = 8;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("VIII", nombreRomain);

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