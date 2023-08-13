using TMPro;
using UnityEngine;

public class OnDestroyWine : MonoBehaviour
{
    public CharacterMessage waiter;
    public TextMeshProUGUI destinationText;

    public void OnDestroy()
    {
        waiter.place = Place_enum.Bar2;
        destinationText.text = Helpers.Languages.SetTextOnDestroyWine();
    }
}
