namespace NombresRomains
{
    public static class Convertisseur
    {
        public static string Convertir(uint chiffreArabe)
        {
            return chiffreArabe switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                _ => "Erreur"
            };
        }
    }
}