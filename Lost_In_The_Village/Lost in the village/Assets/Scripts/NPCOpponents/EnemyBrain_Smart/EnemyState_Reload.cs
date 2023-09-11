using UnityEngine;

namespace LostInTheVillage.NPCOpponents.States.EnemyBrainSmart
{
    public class EnemyState_Reload : IState
    {
        private EnemyReferences enemyReferences;

        public EnemyState_Reload(EnemyReferences enemyReferences)
        {
            this.enemyReferences = enemyReferences;

        }



        public void OnEnter()
        {
            enemyReferences.animator.SetFloat("cover", 1);
            enemyReferences.animator.SetTrigger("reload");
        }

        public void OnExit()
        {
            enemyReferences.animator.SetFloat("cover", 0);
        }

        public void Tick()
        {

        }

        public Color GizmoColor()
        {
            return Color.yellow;
        }
    }
}
