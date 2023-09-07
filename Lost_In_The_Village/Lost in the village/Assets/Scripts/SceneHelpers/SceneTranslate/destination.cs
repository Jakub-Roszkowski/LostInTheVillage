using TMPro;
using UnityEngine;

public class destination : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    void Start()
    {
        promptText.text = Helpers.Languages.SetDestinationVillage2();
    }
    void Update()
    {

    }
}
