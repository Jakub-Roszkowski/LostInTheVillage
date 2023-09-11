using UnityEngine;

namespace LostInTheVillage.MiniGames.RemoveDontDestroy
{
    public class MoveDontDestroyOnLoadObjects : MonoBehaviour
    {
        public static GameObject[] dontDestroyObjects;

        private void Start()
        {
            dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

            foreach (GameObject obj in dontDestroyObjects)
            {
                obj.SetActive(false);
            }
        }
    }
}