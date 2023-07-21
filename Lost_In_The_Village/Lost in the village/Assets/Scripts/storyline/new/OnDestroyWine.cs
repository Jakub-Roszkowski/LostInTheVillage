using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnDestroyWine : MonoBehaviour
{
    public CharacterMessage waiter;
    public TextMeshProUGUI destinationText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy()
    {
        waiter.place = Place_enum.Bar2;
        switch (Language.language)
        {
            case Language_enum.Polish:
                destinationText.text = "kelnerka";
                break;
            case Language_enum.English:
                destinationText.text = "waitress";
                break;
            case Language_enum.German:
                destinationText.text = "Kellnerin";
                break;
            case Language_enum.Spain:
                destinationText.text = "camarera";
                break;
        }
    }
}
