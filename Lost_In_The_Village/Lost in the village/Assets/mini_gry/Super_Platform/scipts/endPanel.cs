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


    private string text1;
    private string text2;
    private string text3;
    private string text4;
    private string text5;
    private string text6;


    private string result;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        img = Panel.GetComponent<Image>();


        switch (Language.language)
        {
            case Language_enum.Polish:
                text1 = "Wygrałeś";
                text2 = "Przegrałeś";
                text3 = "Czas:";
                text4 = "Wynik:";
                text5 = "[Naciśnij F8 aby uruchomić ponownie]";
                text6 = "[Naciśnij F9 aby skończyć gre]";
                break;
            case Language_enum.English:
                text1 = "You won!";
                text2 = "You lost!";
                text3 = "Time:";
                text4 = "Score:";
                text5 = "[Press F8 to restart]";
                text6 = "[Press F9 to end the game]";
                break;
            case Language_enum.German:
                text1 = "Du hast gewonnen!";
                text2 = "Du hast verloren!";
                text3 = "Zeit:";
                text4 = "Punktzahl:";
                text5 = "[Drücken Sie F8, um neu zu starten]";
                text6 = "[Drücken Sie F9, um das Spiel zu beenden]";
                break;
            case Language_enum.Spain:
                text1 = "¡Ganaste!";
                text2 = "¡Perdiste!";
                text3 = "Tiempo:";
                text4 = "Puntuación:";
                text5 = "[Pulsa F8 para reiniciar]";
                text6 = "[Pulsa F9 para terminar el juego]";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
            if (PlayerPlatform.win)
            {
            rezifwin = text1;
                img.color = UnityEngine.Color.green;
            }
            else
            {
            rezifwin = text2;
                img.color = UnityEngine.Color.red;
            }

            result = $"{rezifwin} \n \n {text3}: {PlayerPlatform.timeres}\n{text4} {PlayerPlatform.score}\n \n {text5}\n \n {text6}";

            Score_TMP.text = result;


            
        
        
    }
}
