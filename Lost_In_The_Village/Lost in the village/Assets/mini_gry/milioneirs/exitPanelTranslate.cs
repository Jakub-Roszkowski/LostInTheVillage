using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class exitPanelTranslate : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        switch (Language.language)
        {
            case Language_enum.Polish:
                text.text = "Aby uruchomi� ponownie naci�nij klawisz F8" + "\n" +
                    "Aby zamkn�� gre naci�nij F9";
                break;
            case Language_enum.English:
                text.text = "To restart, press the F8 key." + "\n" + 
                    "To close the game, press F9.";
                break;
            case Language_enum.German:
                text.text = "Um neu zu starten, dr�cke die F8-Taste." + "\n" +
                    "Um das Spiel zu schlie�en, dr�cke die F9-Taste.";
                break;
            case Language_enum.Spain:
                text.text = "Para reiniciar, presiona la tecla F8." + "\n" + 
                    "Para cerrar el juego, presiona la tecla F9.";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
