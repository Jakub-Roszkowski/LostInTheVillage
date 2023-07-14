using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyWine : MonoBehaviour
{
    public CharacterMessage waiter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy()
    {
        waiter.place = Place_enum.Bar2;
    }
}
