using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class LODGroupManager : MonoBehaviour
{
    public Renderer[] renderers;

    void Start()
    {
        Transform interiorObject = transform.Find("interior");
        if (interiorObject != null)
        {
            CollectRenderers(interiorObject);
        }

        LODGroup lodGroup = GetComponent<LODGroup>();
        LOD[] lods = new LOD[1];
        lods[0] = new LOD(0.9f, renderers);
        lodGroup.SetLODs(lods);
        lodGroup.RecalculateBounds();
    }

    void CollectRenderers(Transform parent)
    {
        Renderer[] childRenderers = parent.GetComponentsInChildren<Renderer>();
        renderers = renderers.Concat(childRenderers).ToArray();

        for (int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            CollectRenderers(child);
        }
    }
}
