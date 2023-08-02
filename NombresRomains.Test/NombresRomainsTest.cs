namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Fact]
        public void Test1()
        {
            // Etant donné le chiffre 1
            const uint chiffreArabe = 1;

            // Quand je convertis chiffreArabe en NombreRomain
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);

            // Alors j'obtiens I
            Assert.Equal("I", nombreRomain);    
        }
    }
}