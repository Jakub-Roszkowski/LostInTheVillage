using TMPro;
using UnityEngine;

public class CenrtalTranslate : MonoBehaviour
{
    public TextMeshProUGUI Central;
    void Start()
    {
        Central.text = Helpers.Languages.SetTextCentalBuild();
    }

    void Update()
    {

    }
}