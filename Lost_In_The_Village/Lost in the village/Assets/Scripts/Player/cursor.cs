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
        //// Pobierz pozycjê kursora myszy
        //Vector3 mousePosition = Input.mousePosition;

        //// Pobierz rozmiary ekranu
        //Vector2 screenSize = new Vector2(Screen.width, Screen.height);

        //// SprawdŸ, czy kursor myszy znajduje siê w obszarze wokó³ krawêdzi ekranu
        //bool isCursorOnEdge = mousePosition.x < edgeSize || mousePosition.x > screenSize.x - edgeSize ||
        //                      mousePosition.y < edgeSize || mousePosition.y > screenSize.y - edgeSize;

        //// Jeœli kursor myszy znajduje siê na krawêdzi ekranu, zablokuj ruch kursora
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
