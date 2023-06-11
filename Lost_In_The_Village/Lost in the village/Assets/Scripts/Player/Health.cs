using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
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

    public float GetCurrentHealth()
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

    public void RestoreHealth(int healthToRestore)
    {
        currentHealth += healthToRestore;
    }
}
