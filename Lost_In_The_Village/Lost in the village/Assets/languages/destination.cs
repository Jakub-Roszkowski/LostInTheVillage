using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class destination : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    // Start is called before the first frame update
    void Start()
    {

        switch (Language.language)
        {
            case Language_enum.Polish:
                promptText.text = "Porozmawiaj z cz≥owiekiem przed wioskπ";
                break;
            case Language_enum.English:
                promptText.text = "Talk to the man outside the village";
                break;
            case Language_enum.German:
                promptText.text = "Sprich mit dem Mann auﬂerhalb des Dorfes";
                break;
            case Language_enum.Spain:
                promptText.text = "Habla con el hombre fuera del pueblo.";
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
