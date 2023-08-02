﻿namespace NombresRomains
{
    public static class Convertisseur
    {
        public static string Convertir(uint chiffreArabe)
        {
            return chiffreArabe switch
            {
                <= 3 => new string('I', (int)chiffreArabe),
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => "Erreur"
            };
        }
    }
}