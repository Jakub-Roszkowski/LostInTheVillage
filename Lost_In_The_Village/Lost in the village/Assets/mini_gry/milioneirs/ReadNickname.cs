using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadNickname : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string playerNickname;

    void OnDisable()
    {
        PlayerPrefs.SetString("nickname", playerNickname);

    }

    public void SetNickname(string nickname)
    {
        playerNickname = nickname;
    }
}
