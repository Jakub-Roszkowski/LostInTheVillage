using UnityEngine;

namespace LostInTheVillage.Interactable.Interface
{

    public abstract class AbstractInteractableObject : MonoBehaviour
    {
        public string PromptMessage_() { return PromptMessage(); }
        public void Interact_() { Interact(); }
        public void Interact2_() { Interact2(); }

        protected abstract string PromptMessage();
        protected abstract void Interact();
        protected abstract void Interact2();
    }
}
