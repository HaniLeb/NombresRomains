namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Fact(DisplayName = "Etant donné le chiffre 1" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens I")]
        public void Test1()
        {
            const uint chiffreArabe = 1;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("I", nombreRomain);
        }

        [Fact(DisplayName = "Etant donné le chiffre 2" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens II")]
        public void Test2()
        {
            const uint chiffreArabe = 2;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("II", nombreRomain);

        }
    }
}