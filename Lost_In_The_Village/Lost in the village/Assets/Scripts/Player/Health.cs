using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            if (IsPlayer())
            {
                Scene activeScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(activeScene.buildIndex);
            }
            else
            {
                Animator animator = this.GetComponent<Animator>();
                animator.SetBool("isDead", true);
            }
        }
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }


    private void Die()
    {
        gameObject.SetActive(false);
    }

    private bool IsPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        return (gameObject == player);
    }

}
