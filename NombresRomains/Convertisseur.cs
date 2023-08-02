namespace NombresRomains
{
    public class Convertisseur
    {
        public static string Convertir(uint chiffreArabe)
        {
            return chiffreArabe switch
            {
                1 => "I",
                2 => "II",
                _ => "Erreur"
            };
        }
    }
}