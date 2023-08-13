using UnityEngine;

public abstract class AbstractInteractableObject : MonoBehaviour
{
    public string promptMessage_() {return promptMessage(); }
    public void Interact_() { Interact(); }
    public void Interact2_() { Interact2(); }

    protected abstract string promptMessage();
    protected abstract void Interact();
    protected abstract void Interact2();
}
