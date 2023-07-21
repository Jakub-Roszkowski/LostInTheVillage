using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public GameObject panelBlood;

    public float fadeDuration = 1f;
    public float fadeDelay = 0.5f;

    private CanvasGroup canvasGroup;
    private RawImage bloodImage;

    private int nearDeathValue = 40;
    private bool death = false;
    public static GameObject[] dontDestroyObjects;


    private void Start()
    {
        currentHealth = maxHealth;
        death = false;
        //panelBlood.SetActive(false);
    }

    public void Update()
    {
        if (IsPlayer())
        {
            //if (currentHealth < nearDeathValue)
            //{

            //    panelBlood.SetActive(false);
            //    canvasGroup = panelBlood.GetComponent<CanvasGroup>();
            //    if (canvasGroup == null)
            //    {
            //        canvasGroup = panelBlood.AddComponent<CanvasGroup>();
            //    }

            //    bloodImage = panelBlood.GetComponentInChildren<RawImage>();

            //    canvasGroup.alpha = 1f;
            //    StopAllCoroutines();

            //    panelBlood.SetActive(true);

            //    float frameDuration = fadeDuration / 60f;

            //        float alpha = 0.7f;
            //        canvasGroup.alpha = alpha;
            //        if (bloodImage != null)
            //        {
            //            Color imageColor = bloodImage.color;
            //            imageColor.a = alpha;
            //            bloodImage.color = imageColor;
            //        }
            //}
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (IsPlayer() && damage>0 && (currentHealth >= nearDeathValue))
        {

                ShowBloodPanel();
            
            
        }

        if (IsPlayer())
        {
            if (currentHealth < nearDeathValue)
            {

                panelBlood.SetActive(false);
                canvasGroup = panelBlood.GetComponent<CanvasGroup>();
                if (canvasGroup == null)
                {
                    canvasGroup = panelBlood.AddComponent<CanvasGroup>();
                }

                bloodImage = panelBlood.GetComponentInChildren<RawImage>();

                canvasGroup.alpha = 1f;
                StopAllCoroutines();

                panelBlood.SetActive(true);

                float frameDuration = fadeDuration / 60f;

                float alpha = 0.7f;
                canvasGroup.alpha = alpha;
                if (bloodImage != null)
                {
                    Color imageColor = bloodImage.color;
                    imageColor.a = alpha;
                    bloodImage.color = imageColor;
                }
            }
        }

        if (currentHealth <= 0)
        {
            if (IsPlayer() && death ==false)
            {
                death = true;
                dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

                foreach (GameObject obj in dontDestroyObjects)
                {
                    Destroy(obj);
                }
                SceneManager.LoadScene(sceneMenager2.currentScene);
            }
            else if(!IsPlayer())
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
        if (gameObject.tag == "Player")
        {
            return true;
        }
        else
            return false;
    }

    public void RestoreHealth(int healthToRestore)
    {
        if((currentHealth + healthToRestore) >= nearDeathValue && currentHealth<100)
        {
            canvasGroup.alpha = 0f;
            panelBlood.SetActive(false);
            ShowBloodPanel();
        }
        currentHealth += healthToRestore;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }




    public void ShowBloodPanel()
    {
        panelBlood.SetActive(false);
        canvasGroup = panelBlood.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = panelBlood.AddComponent<CanvasGroup>();
        }

        bloodImage = panelBlood.GetComponentInChildren<RawImage>();

        canvasGroup.alpha = 1f;
        StopAllCoroutines();

        panelBlood.SetActive(true);

        StartCoroutine(FadeBloodImage());
    }

    private System.Collections.IEnumerator FadeBloodImage()
    {
        yield return new WaitForSeconds(fadeDelay);

        float frameDuration = fadeDuration / 60f;

        for (float time = fadeDuration; time > 0f; time -= frameDuration)
        {

            float alpha = time / fadeDuration;

            canvasGroup.alpha = alpha;

            if (bloodImage != null)
            {
                Color imageColor = bloodImage.color;
                imageColor.a = alpha;
                bloodImage.color = imageColor;
            }
            yield return new WaitForSeconds(frameDuration);
        }
        canvasGroup.alpha = 0f;
        panelBlood.SetActive(false);
    }
}
