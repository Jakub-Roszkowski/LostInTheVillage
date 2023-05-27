using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDemage : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDemage(int demage)
    {
        player.health -= demage;

    }
}
