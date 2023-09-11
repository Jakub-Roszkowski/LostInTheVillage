using LostInTheVillage.Character;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.Storyline.Wine
{
    public class OnDestroyWine : MonoBehaviour
    {
        [SerializeField] private CharacterMessage waiterCharacter;
        [SerializeField] private TextMeshProUGUI destinationText;

        private void OnDestroy()
        {
            waiterCharacter.Place = PlaceEnum.Bar2;
            destinationText.text = Helpers.Languages.SetTextOnDestroyWine();
        }
    }
}
