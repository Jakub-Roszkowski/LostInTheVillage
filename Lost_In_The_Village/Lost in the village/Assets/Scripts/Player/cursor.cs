using UnityEngine;

namespace LostInTheVillage.Player
{
    public class Cursor : MonoBehaviour
    {
        private void Start()
        {
            UnityEngine.Cursor.visible = false;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
