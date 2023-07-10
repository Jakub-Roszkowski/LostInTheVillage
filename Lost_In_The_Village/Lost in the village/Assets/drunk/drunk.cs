using UnityEngine;
using System.Collections;

public class drunk : MonoBehaviour
{
    public Material material;
    private bool isEffectActive = false;

    private void Start()
    {
        isEffectActive = false;
    }

    public void DrunkEffect()
    {
        StartCoroutine(ActivateEffectAfterDelay());
    }

    private IEnumerator ActivateEffectAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);
        isEffectActive = true;

        yield return new WaitForSeconds(40f);
        isEffectActive = false;
    }


    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (isEffectActive)
        {
            Graphics.Blit(source, destination, material);
        }
        else
        {
            // Jeśli efekt jest wyłączony, przekazuj bez zmian
            Graphics.Blit(source, destination);
        }
    }
}