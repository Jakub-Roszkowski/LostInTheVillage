using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifCurrent2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( test_milioneirs.CurrentPosition == 2) { transform.GetComponent<Image>().color = Color.red; }
        else transform.GetComponent<Image>().color = new Color(0.0017f, 0.0f, 0.7547f);

    }


}
