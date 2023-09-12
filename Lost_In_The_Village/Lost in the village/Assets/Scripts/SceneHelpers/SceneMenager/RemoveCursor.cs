using UnityEngine;

namespace LostInTheVillage.SceneHelpers.SceneMenager
{
    public class RemoveCursor : MonoBehaviour
    {
        private void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
