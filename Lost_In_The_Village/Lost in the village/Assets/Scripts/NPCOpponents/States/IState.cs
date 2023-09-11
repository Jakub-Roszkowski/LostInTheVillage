using UnityEngine;

namespace LostInTheVillage.NPCOpponents.States
{
    public interface IState
    {
        void Tick();
        void OnEnter();
        void OnExit();
        Color GizmoColor()
        {
            return Color.black;
        }
    }
}