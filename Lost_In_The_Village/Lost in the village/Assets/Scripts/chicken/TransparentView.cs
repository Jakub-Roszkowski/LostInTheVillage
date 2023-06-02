using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentView : MonoBehaviour
{
    // Ustaw przezroczystość obiektu
    public float transparency = 0.5f;

    // Pamiętaj początkową wartość przezroczystości
    private Material material;

    private void Start()
    {
        // Pobierz komponent Renderer obiektu
        Renderer renderer = GetComponent<Renderer>();

        // Utwórz kopię materiału, aby móc zmieniać przezroczystość niezależnie od innych obiektów
        material = renderer.material;
        material.SetFloat("_Mode", 2);
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;

        // Ustaw przezroczystość na początku
        SetTransparency(transparency);
    }

    public void SetTransparency(float newTransparency)
    {
        // Ogranicz wartość przezroczystości od 0 do 1
        float clampedTransparency = Mathf.Clamp01(newTransparency);

        // Ustaw wartość przezroczystości w materiale
        Color color = material.color;
        color.a = clampedTransparency;
        material.color = color;
    }
}






