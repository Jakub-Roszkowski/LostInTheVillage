using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CenrtalTranslate : MonoBehaviour
{
    public TextMeshProUGUI Central;
    // Start is called before the first frame update
    void Start()
    {
        switch (Language.language)
        {
            case Language_enum.Polish:
                Central.text = "Centrala";
                break;
            case Language_enum.English:
                Central.text = "Headquarters";
                break;
            case Language_enum.German:
                Central.text = "Zentral";
                break;
            case Language_enum.Spain:
                Central.text = "la sede";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
