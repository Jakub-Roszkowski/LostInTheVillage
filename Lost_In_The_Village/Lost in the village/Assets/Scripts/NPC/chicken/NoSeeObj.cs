using UnityEngine;

namespace LostInTheVillage.NPC.Chicken
{
    public class NoSeeObj : MonoBehaviour
    {
        private bool isVisible = true;
        private Renderer renderer;

        private void Start()
        {
            renderer = GetComponent<Renderer>();
            SetVisibility(isVisible);
        }

        public void SetVisibility(bool visible)
        {
            isVisible = visible;
            renderer.enabled = isVisible;
        }
    }
}

