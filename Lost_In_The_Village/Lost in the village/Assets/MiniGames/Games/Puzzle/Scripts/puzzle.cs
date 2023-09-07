using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private float moveSpeed = 5f; 

    void Start()
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
                time_and_rest.changemusic(1);
                StartCoroutine(MoveToInitialPosition(collision.gameObject));

            }
            else
            {
                time_and_rest.changemusic(0);
                time_and_rest.counter++;
                spriteRenderer.enabled = true;

                Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                SpriteRenderer sr = collision.gameObject.GetComponent<SpriteRenderer>();
                rb.isKinematic = true;
                sr.enabled = false;

            }
        }
    }

    IEnumerator MoveToInitialPosition(GameObject obj)
    {
        Vector3 initialPosition = obj.GetComponent<MouseDrag>().initialPosition;
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

        // Wy³¹cz Rigidbody
        rb.isKinematic = true;

        while (Vector3.Distance(obj.transform.position, initialPosition) > 0.01f)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, initialPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }

    }
}