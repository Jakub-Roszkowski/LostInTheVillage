using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    //public float edgeSize = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        // Zablokuj ruch kursora myszy w oknie gry
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        //// Pobierz pozycj� kursora myszy
        //Vector3 mousePosition = Input.mousePosition;

        //// Pobierz rozmiary ekranu
        //Vector2 screenSize = new Vector2(Screen.width, Screen.height);

        //// Sprawd�, czy kursor myszy znajduje si� w obszarze wok� kraw�dzi ekranu
        //bool isCursorOnEdge = mousePosition.x < edgeSize || mousePosition.x > screenSize.x - edgeSize ||
        //                      mousePosition.y < edgeSize || mousePosition.y > screenSize.y - edgeSize;

        //// Je�li kursor myszy znajduje si� na kraw�dzi ekranu, zablokuj ruch kursora
        //if (isCursorOnEdge)
        //{
        //    Cursor.lockState = CursorLockMode.Confined;
        //}
        //else
        //{
        //    // W przeciwnym razie, odblokuj ruch kursora
        //    Cursor.lockState = CursorLockMode.None;
        //}
    }
}
