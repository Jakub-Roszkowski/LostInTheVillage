using UnityEngine;
using UnityEngine.UI;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts.IfCurrent
{
    public class ifCurrent4 : MonoBehaviour
    {
        void Update()
        {
            if (TestMilioneirs.CurrentPosition == 4) { transform.GetComponent<Image>().color = Color.red; }
            else transform.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.3921f);

        }
    }
}
