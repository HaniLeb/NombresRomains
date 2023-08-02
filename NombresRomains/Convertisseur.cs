namespace NombresRomains
{
    public class Convertisseur
    {
        public static string Convertir(uint chiffreArabe)
        {
            switch (chiffreArabe)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                default:
                    return "Erreur";
            }
        }
    }
}