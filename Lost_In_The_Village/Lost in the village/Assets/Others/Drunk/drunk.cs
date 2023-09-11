using UnityEngine;
using System.Collections;

public class Drunk : MonoBehaviour
{
    public Material material;
    private bool isEffectActive = false;

    private void Start()
    {
        isEffectActive = false;
    }


    public void DisableDrunkEffect()
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
            Graphics.Blit(source, destination);
        }
    }
}