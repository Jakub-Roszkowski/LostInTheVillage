using System.Collections;
using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Puzzle.Scripts
{
    public class Puzzle : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        private float moveSpeed = 5f;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.enabled = false;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject != null)
            {
                if (collision.gameObject.name != gameObject.name)
                {
                    PuzzleTimerController.ChangeMusic(1);
                    StartCoroutine(MoveToInitialPosition(collision.gameObject));
                }
                else
                {
                    PuzzleTimerController.ChangeMusic(0);
                    PuzzleTimerController.Counter++;
                    spriteRenderer.enabled = true;

                    Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                    SpriteRenderer sr = collision.gameObject.GetComponent<SpriteRenderer>();
                    rb.isKinematic = true;
                    sr.enabled = false;
                }
            }
        }

        private IEnumerator MoveToInitialPosition(GameObject obj)
        {
            Vector3 initialPosition = obj.GetComponent<MouseDrag>().InitialPosition;
            Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

            rb.isKinematic = true;

            while (Vector3.Distance(obj.transform.position, initialPosition) > 0.01f)
            {
                obj.transform.position = Vector3.MoveTowards(obj.transform.position, initialPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }
}