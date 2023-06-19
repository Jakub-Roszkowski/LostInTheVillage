using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class notseeobj : MonoBehaviour
{

    public bool isVisible = true;

    private Renderer renderer;

    private void Start()
    {

        renderer = GetComponent<Renderer>();

        SetVisibility(isVisible);
    }

    public void SetVisibility(bool visible)
    {
        isVisible = visible;

        renderer.enabled = isVisible;
    }
}

