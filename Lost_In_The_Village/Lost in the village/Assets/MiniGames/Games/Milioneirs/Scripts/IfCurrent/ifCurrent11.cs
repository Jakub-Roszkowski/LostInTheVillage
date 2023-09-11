using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts.IfCurrent
{
    public class ifCurrent11 : MonoBehaviour
    {
        void Update()
        {
            if (TestMilioneirs.CurrentPosition == 11) { transform.GetComponent<Image>().color = Color.red; }
            else transform.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.3921f);

        }
    }
}
