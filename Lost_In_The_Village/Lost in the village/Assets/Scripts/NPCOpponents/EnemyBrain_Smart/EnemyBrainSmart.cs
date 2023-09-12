using LostInTheVillage.NPCOpponents.States;
using System;
using UnityEngine;

namespace LostInTheVillage.NPCOpponents.EnemyBrainSmart
{
    public class EnemyBrainSmart : MonoBehaviour
    {
        private EnemyReferences enemyReferences;
        public CoverArea coverArea;
        private StateMachine stateMachine;

        private void Start()
        {
            enemyReferences = GetComponent<EnemyReferences>();
            stateMachine = new StateMachine();

            //States
            var patrol = new EnemyState_Patroling(enemyReferences, coverArea);
            var change = new EnemyState_Wait(0.2f);
            var cover = new EnemyState_Cover(enemyReferences);
            var runToCover = new EnemyState_RunToCover(enemyReferences, coverArea);

            //Transitions
            At(patrol, change, () => patrol.PlayerSpotted());
            At(change, runToCover, () => change.IsDone());
            At(runToCover, cover, () => runToCover.HasArrivedAtDestination());
            At(cover, patrol, () => !cover.ShouldCover());

            //Start state
            stateMachine.SetState(patrol);

            //Functions
            void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
            void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);
        }

        private void Update()
        {
            stateMachine.Tick();
        }

        private void OnDrawGizmos()
        {
            if (stateMachine != null)
            {
                Gizmos.color = stateMachine.GetGizmoColor();
                Gizmos.DrawSphere(transform.position + Vector3.up * 3, 0.4f);
            }
        }
    }
}
