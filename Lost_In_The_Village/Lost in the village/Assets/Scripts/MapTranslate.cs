using UnityEngine;

public class MapTranslate : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject map4;
    void Start()
    {
        switch (Language.language)
        {
            case Language_enum.Polish:
                map1.SetActive(true);
                break;
            case Language_enum.English:
                map2.SetActive(true);
                break;
            case Language_enum.German:
                map3.SetActive(true);
                break;
            case Language_enum.Spain:
                map4.SetActive(true);
                break;
        }
    }
    void Update() { }
}
