using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Puzzle.Scripts
{
    public class MouseDrag : MonoBehaviour
    {
        public Vector3 InitialPosition { get; set; }

        private Vector3 offset;
        private bool isDragging = false;
        private Rigidbody2D rb;

        private bool isInArea = false;
        private Vector2 minPosition = new Vector2(-21f, -18f);
        private Vector2 maxPosition = new Vector2(-3f, 9f);

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();

            rb.isKinematic = true;

            float randomX = Random.Range(-0f, 12f);
            float randomY = Random.Range(-0.5f, 5.3f);

            transform.position = new Vector3(randomX, randomY, transform.position.z);
        }

        private void OnMouseDown()
        {
            offset = transform.position - GetMouseWorldPosition();
            isDragging = true;
            rb.isKinematic = true;
            UpdateInitialPosition();
        }

        private void OnMouseUp()
        {
            isDragging = false;

            if (isInArea)
            {
                rb.isKinematic = false;
            }
        }

        private void Update()
        {
            if (isDragging)
            {
                Vector3 mousePos = GetMouseWorldPosition();
                transform.position = mousePos + offset;

                isInArea = transform.position.x >= minPosition.x &&
                           transform.position.x <= maxPosition.x &&
                           transform.position.y >= minPosition.y &&
                           transform.position.y <= maxPosition.y;
            }
        }

        private Vector3 GetMouseWorldPosition()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            return Camera.main.ScreenToWorldPoint(mousePos);

        }

        private void UpdateInitialPosition()
        {
            InitialPosition = transform.position;
        }
    }
}