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
                rezifwin = "Wygra�e�";
                img.color = UnityEngine.Color.green;
            }
            else
            {
                rezifwin = "Przegra�e�";
                img.color = UnityEngine.Color.red;
            }

            result = $"{rezifwin} \n \n Czas: {PlayerPlatform.timeres}\nWynik: {PlayerPlatform.score}\n \n [Naci�nij F8 aby uruchomi� ponownie]\n \n [Naci�nij F9 aby sko�czy� gre";

            Score_TMP.text = result;


            
        
        
    }
}
