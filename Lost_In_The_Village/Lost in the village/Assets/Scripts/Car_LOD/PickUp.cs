using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Renderer[] renderers;
    void Start()
    {
        CollectRenderers(transform);

        if (renderers.Length > 0)
        {
            LODGroup lodGroup = GetComponent<LODGroup>();
            LOD[] lods = new LOD[1];
            lods[0] = new LOD(0.12f, renderers);
            lodGroup.SetLODs(lods);
            lodGroup.RecalculateBounds();
        }
    }

    void CollectRenderers(Transform parent)
    {
        Renderer[] childRenderers = parent.GetComponentsInChildren<Renderer>(true);
        renderers = renderers.Concat(childRenderers).ToArray();

        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            CollectRenderers(child);
        }
    }
}
