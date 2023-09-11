using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneMenager
{
    public class RemoveCursor : MonoBehaviour
    {
        private void Start()
        {
            UnityEngine.Cursor.visible = false;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
