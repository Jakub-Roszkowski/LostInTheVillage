using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentView : MonoBehaviour
{
    public float transparency = 0.5f;

    private Material material;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        material = renderer.material;
        material.SetFloat("_Mode", 2);
        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;

        SetTransparency(transparency);
    }

    public void SetTransparency(float newTransparency)
    {
        float clampedTransparency = Mathf.Clamp01(newTransparency);

        Color color = material.color;
        color.a = clampedTransparency;
        material.color = color;
    }
}






