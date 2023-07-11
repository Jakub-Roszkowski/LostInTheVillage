using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class LODGroupManager : MonoBehaviour
{
    public Renderer[] renderers; // Tablica na modele renderowania

    void Start()
    {
        Transform wineObject = transform.Find("wina");
        if (wineObject != null)
        {
            CollectRenderers(wineObject);
        }
        Transform interiorObject = transform.Find("interior");
        if (interiorObject != null)
        {
            CollectRenderers(interiorObject);
        }

        LODGroup lodGroup = GetComponent<LODGroup>();
        LOD[] lods = new LOD[1];
        lods[0] = new LOD(1f, renderers);
        lodGroup.SetLODs(lods);
        lodGroup.RecalculateBounds();
    }

    void CollectRenderers(Transform parent)
    {
        // Pobierz modele renderowania z obiektu i jego dzieci i dodaj je do tablicy renderujπcej
        Renderer[] childRenderers = parent.GetComponentsInChildren<Renderer>();
        renderers = renderers.Concat(childRenderers).ToArray();

        // Rekurencyjnie przechodü przez dzieci i zbieraj modele renderowania
        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            CollectRenderers(child);
        }
    }
}
