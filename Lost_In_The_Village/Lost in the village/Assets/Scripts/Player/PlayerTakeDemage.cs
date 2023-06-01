using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (player.health < 0)
            Restart_game();

    }
    public void Restart_game()
    {

            Time.timeScale = 1f;
            Retry();
        
    }

    public void Retry()
    {
        //Restarts current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
