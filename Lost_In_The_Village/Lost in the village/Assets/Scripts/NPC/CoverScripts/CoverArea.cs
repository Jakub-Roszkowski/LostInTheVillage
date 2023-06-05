using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverArea : MonoBehaviour
{

    private Cover[] covers;

    private void Awake()
    {
        covers = GetComponentsInChildren<Cover>();
    }

    public Cover GetRandomCover(Vector3 agentLocation)
    {
        return covers[Random.Range(0, covers.Length - 1)];
    }

}
