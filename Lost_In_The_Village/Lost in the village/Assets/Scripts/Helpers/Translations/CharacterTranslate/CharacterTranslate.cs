using LostInTheVillage.Character;
using LostInTheVillage.SceneHelpers.SceneTranslate;
using UnityEngine;

namespace LostInTheVillage.Helpers.Translations.CharacterTranslate
{
    public static class CharacterTranslate
    {
        public static (AudioClip, string, string) Translate(PlaceEnum place, CharacterSounds sounds)
        {
            AudioClip audio = null;
            string promptString = "";
            string destinationString = "";

            (promptString, destinationString, audio) = TranslateDictionary(place, sounds);

            return (audio, promptString, destinationString);
        }

        private static (string, string, AudioClip) TranslateDictionary(PlaceEnum place, CharacterSounds sounds)
        {
            var dictionary = CharacterTranslateDictionary.SetTranslation(sounds);

            if (dictionary.TryGetValue(Language.LanguageName, out var translations))
            {
                if (translations.TryGetValue(place, out var translatedValue))
                {
                    return translatedValue;
                }
            }
            return (string.Empty, string.Empty, null);
        }
    }
}

