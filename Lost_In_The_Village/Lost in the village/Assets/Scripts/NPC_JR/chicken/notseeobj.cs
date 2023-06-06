using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class notseeobj : MonoBehaviour
{
    // Ustaw przezroczystoœæ obiektu
    public bool isVisible = true;

    private Renderer renderer;

    private void Start()
    {
        // Pobierz komponent Renderer obiektu
        renderer = GetComponent<Renderer>();

        // Ustaw widocznoœæ na pocz¹tku
        SetVisibility(isVisible);
    }

    public void SetVisibility(bool visible)
    {
        isVisible = visible;

        // W³¹cz lub wy³¹cz renderowanie obiektu
        renderer.enabled = isVisible;
    }
}


//mozna dodac zeby strzelanie nie zostawialo sladow tutaj