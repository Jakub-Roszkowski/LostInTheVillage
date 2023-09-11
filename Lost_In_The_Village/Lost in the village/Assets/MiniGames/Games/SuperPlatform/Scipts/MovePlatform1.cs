using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class MovePlatform1 : MonoBehaviour
    {

        [SerializeField] private GameObject[] waypoints;
        private int currentWaypointIndex = 0;

        [SerializeField] private float speed = 5f;

        private void Update()
        {
            if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 0;
                }
            }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            collision.transform.SetParent(transform);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            collision.transform.SetParent(null);
        }
    }
}
