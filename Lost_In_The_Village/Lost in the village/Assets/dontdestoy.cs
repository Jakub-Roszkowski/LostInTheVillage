using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestoy : MonoBehaviour
{

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    

}
