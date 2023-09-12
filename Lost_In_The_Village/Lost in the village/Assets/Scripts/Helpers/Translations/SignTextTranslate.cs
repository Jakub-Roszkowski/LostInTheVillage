using LostInTheVillage.SceneHelpers.SceneTranslate;
using System.Collections.Generic;

namespace LostInTheVillage.Helpers.Translations
{
    public static class SignTextTranslate
    {
        private static Dictionary<LanguageEnum, Dictionary<StreetName, string>> streetTranslations = new Dictionary<LanguageEnum, Dictionary<StreetName, string>>()
        {
            {
                LanguageEnum.Polish, new Dictionary<StreetName, string>
                {
                    { StreetName.DistantStreet, "Odległa" },
                    { StreetName.MainStreet, "Główna" },
                    { StreetName.QuietStreet, "Cicha" },
                    { StreetName.DowntownStreet, "Śródmiejska" },
                    { StreetName.GermanStreet, "Niemiecka" },
                    { StreetName.TentStreet, "Namiotowa" },
                    { StreetName.ParkStreet, "Parkowa" },
                    { StreetName.ArchitectsStreet, "Architektów" },
                    { StreetName.ChineseStreet, "Chińska" },
                    { StreetName.VillageStreet, "Wiejska" },
                    { StreetName.CowshedStreet, "Obornicka" },
                }
            },
            {
                LanguageEnum.English, new Dictionary<StreetName, string>
                {
                    { StreetName.DistantStreet, "Distant st." },
                    { StreetName.MainStreet, "Main st." },
                    { StreetName.QuietStreet, "Quiet st." },
                    { StreetName.DowntownStreet, "Downtown st." },
                    { StreetName.GermanStreet, "German st." },
                    { StreetName.TentStreet, "Tent st." },
                    { StreetName.ParkStreet, "Parks st." },
                    { StreetName.ArchitectsStreet, "Architects st." },
                    { StreetName.ChineseStreet, "Chinese st." },
                    { StreetName.VillageStreet, "Village st." },
                    { StreetName.CowshedStreet, "Cowshed st." },
                }
            },
            {
                LanguageEnum.German, new Dictionary<StreetName, string>
                {
                    { StreetName.DistantStreet, "Entfernte Straße" },
                    { StreetName.MainStreet, "Hauptstraße" },
                    { StreetName.QuietStreet, "Ruhige Straße" },
                    { StreetName.DowntownStreet, "Innenstadtstraße" },
                    { StreetName.GermanStreet, "Deutsche Straße" },
                    { StreetName.TentStreet, "Zeltstraße" },
                    { StreetName.ParkStreet, "Parkstraße" },
                    { StreetName.ArchitectsStreet, "Architektenstraße" },
                    { StreetName.ChineseStreet, "Chinesische Straße" },
                    { StreetName.VillageStreet, "Dorfstraße" },
                    { StreetName.CowshedStreet, "Kuhstallstraße" },
                }
            },
            {
                LanguageEnum.Spanish, new Dictionary<StreetName, string>
                {
                    { StreetName.DistantStreet, "Calle distante" },
                    { StreetName.MainStreet, "Calle principal" },
                    { StreetName.QuietStreet, "Calle tranquila" },
                    { StreetName.DowntownStreet, "Calle del centro" },
                    { StreetName.GermanStreet, "Calle alemana" },
                    { StreetName.TentStreet, "Tent Street" },
                    { StreetName.ParkStreet, "calle del Parque" },
                    { StreetName.ArchitectsStreet, "Calle Arquitectos" },
                    { StreetName.ChineseStreet, "Calle china" },
                    { StreetName.VillageStreet, "calle del pueblo" },
                    { StreetName.CowshedStreet, "calle establo" },
                }
            },
        };
        public static string TranslateStreet(StreetName street)
        {
            if (streetTranslations.TryGetValue(Language.LanguageName, out var translations))
            {
                if (translations.TryGetValue(street, out var translatedText))
                {
                    return translatedText;
                }
            }

            return string.Empty;
        }
    }
}

