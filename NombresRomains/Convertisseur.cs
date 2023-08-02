namespace NombresRomains
{
    public static class Convertisseur
    {
        public static string Convertir(uint chiffreArabe)
        {
            return chiffreArabe switch
            {
                <= 3 => new string('I', (int)chiffreArabe),
                4 => "IV",
                < 9 => "V" + Convertir(chiffreArabe - 5),
                9 => "IX",
                10 => "X",
                _ => "Erreur"
            };
        }
    }
}