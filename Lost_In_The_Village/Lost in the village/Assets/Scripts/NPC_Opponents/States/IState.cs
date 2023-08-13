using UnityEngine;

public interface IState
{
    void Tick();
    void OnEnter();
    void OnExit();
    Color GizmoColor() {
        return Color.black;
    }
}