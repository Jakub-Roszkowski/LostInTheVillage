using UnityEngine;

namespace LostInTheVillage.SceneHelpers
{
    public class DontDestroy : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}