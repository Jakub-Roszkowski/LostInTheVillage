using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class endPanel : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text Score_TMP;
    public TMP_Text ifWin;
    private Image img;
    private string rezifwin="";

    private string result;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        img = Panel.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        
            if (PlayerPlatform.win)
            {
                rezifwin = "Wygra³eœ";
                img.color = UnityEngine.Color.green;
            }
            else
            {
                rezifwin = "Przegra³eœ";
                img.color = UnityEngine.Color.red;
            }

            result = $"{rezifwin} \n \n Czas: {PlayerPlatform.timeres}\nWynik: {PlayerPlatform.score}\n \n [Naciœnij F8 aby uruchomiæ ponownie]\n \n [Naciœnij F9 aby skoñczyæ gre";

            Score_TMP.text = result;


            
        
        
    }
}
