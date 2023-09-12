using LostInTheVillage.Helpers;
using LostInTheVillage.NPCOpponents.EnemyBrainSmart;
using LostInTheVillage.NPCOpponents.States;
using System;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

namespace LostInTheVillage.NPCOpponents
{
    public class EnemyStatePatrolingStupid : IState
    {
        public Vector3 destination { get; set; }

        private float spottingDistance = ConfigNumbers.SpottingDistanceNPC_Stupid;

        private EnemyReferences enemyReferences;
        private GameObject player;
        private Transform target;

        private Cover currentCover = null;
        private StateMachine stateMachine;
        private bool walkPointSet = false;
        private int walkPointRange = 6;
        private Vector3 walkPoint;

        public EnemyStatePatrolingStupid(EnemyReferences enemyReferences, GameObject player)
        {
            this.enemyReferences = enemyReferences;
            this.player = player;

            stateMachine = new StateMachine();

            //Functions
            void At(IState from, IState to, Func<bool> condition) => stateMachine.AddTransition(from, to, condition);
            void Any(IState to, Func<bool> condition) => stateMachine.AddAnyTransition(to, condition);
        }

        public void OnEnter()
        {
            target = GameObject.FindWithTag("Player").transform;
            enemyReferences.animator.SetBool("shooting", false);
            enemyReferences.animator.SetBool("isWalking", true);
        }

        public void OnExit()
        {
            enemyReferences.animator.SetBool("isWalking", false);
            target = null;
        }

        public void Tick()
        {
            stateMachine.Tick();
            if (!PlayerSpotted())
            {
                if (!walkPointSet) SearchWalkPoint();
                if (walkPointSet) enemyReferences.navMeshAgent.SetDestination(walkPoint);

                Vector3 distanceToWalkPoint = enemyReferences.transform.position - walkPoint;

                if (distanceToWalkPoint.magnitude < 1f)
                {
                    walkPointSet = false;
                }
            }
        }

        private void SearchWalkPoint()
        {
            float randomZ = Random.Range(-walkPointRange, walkPointRange);
            float randomX = Random.Range(-walkPointRange, walkPointRange);

            walkPoint = new Vector3(enemyReferences.transform.position.x + randomX,
                enemyReferences.transform.position.y,
                enemyReferences.transform.position.z + randomZ);

            if (Physics.Raycast(walkPoint, -enemyReferences.transform.up, 2f, enemyReferences.whatIsGround))
            {
                walkPointSet = true;
            }
        }

        public bool PlayerSpotted()
        {
            return Vector3.Distance(enemyReferences.transform.position, target.position) <= spottingDistance;
        }

        public Color GizmoColor()
        {
            return Color.white;
        }
    }
}
