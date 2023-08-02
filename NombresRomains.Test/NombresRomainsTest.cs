namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Fact(DisplayName = "Etant donn� le chiffre 1" +
                            "Quand je convertis chiffreArabe en NombreRomain" +
                            "Alors j'obtiens I")]
        public void Test1()
        {
            const uint chiffreArabe = 1;

            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            Assert.Equal("I", nombreRomain);
        }
    }
}