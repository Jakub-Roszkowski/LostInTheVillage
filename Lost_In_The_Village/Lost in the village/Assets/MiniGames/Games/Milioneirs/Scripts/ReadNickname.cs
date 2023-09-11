using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class ReadNickname : MonoBehaviour
    {
        string playerNickname;

        private void OnDisable()
        {
            PlayerPrefs.SetString("nickname", playerNickname);
        }

        public void SetNickname(string nickname)
        {
            playerNickname = nickname;
        }
    }
}
