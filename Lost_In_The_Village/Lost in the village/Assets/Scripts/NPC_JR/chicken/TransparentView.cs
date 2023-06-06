using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentView : MonoBehaviour
{
    // Ustaw przezroczysto�� obiektu
    public float transparency = 0.5f;

    // Pami�taj pocz�tkow� warto�� przezroczysto�ci
    private Material material;

    private void Start()
    {
        // Pobierz komponent Renderer obiektu
        Renderer renderer = GetComponent<Renderer>();

        // Utw�rz kopi� materia�u, aby m�c zmienia� przezroczysto�� niezale�nie od innych obiekt�w
        material = renderer.material;
        material.SetFloat("_Mode", 2);
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;

        // Ustaw przezroczysto�� na pocz�tku
        SetTransparency(transparency);
    }

    public void SetTransparency(float newTransparency)
    {
        // Ogranicz warto�� przezroczysto�ci od 0 do 1
        float clampedTransparency = Mathf.Clamp01(newTransparency);

        // Ustaw warto�� przezroczysto�ci w materiale
        Color color = material.color;
        color.a = clampedTransparency;
        material.color = color;
    }
}






