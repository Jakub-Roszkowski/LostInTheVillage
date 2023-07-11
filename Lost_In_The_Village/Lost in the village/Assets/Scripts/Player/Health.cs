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
            if (currentHealth < nearDeathValue)
            {

                // Upewnij siê, ¿e panelBlood jest ukryty na pocz¹tku
                panelBlood.SetActive(false);

                // Pobierz lub dodaj komponent CanvasGroup do paneluBlood
                canvasGroup = panelBlood.GetComponent<CanvasGroup>();
                if (canvasGroup == null)
                {
                    canvasGroup = panelBlood.AddComponent<CanvasGroup>();
                }

                // Pobierz komponent RawImage z dziecka panelBlood
                bloodImage = panelBlood.GetComponentInChildren<RawImage>();

                // Zresetuj wartoœci przezroczystoœci i przerwij poprzedni¹ animacjê, jeœli by³a uruchomiona
                canvasGroup.alpha = 1f;
                StopAllCoroutines();

                // Wyœwietl panelBlood
                panelBlood.SetActive(true);

                // Oblicz czas dla pojedynczej klatki animacji
                float frameDuration = fadeDuration / 60f;

                // Wykonuj animacjê zmiany przezroczystoœci w pêtli
                
                    // Oblicz now¹ wartoœæ przezroczystoœci w oparciu o czas
                    float alpha = 0.7f;

                    // Ustaw now¹ wartoœæ przezroczystoœci dla CanvasGroup paneluBlood
                    canvasGroup.alpha = alpha;

                    // Ustaw now¹ wartoœæ przezroczystoœci dla obrazu "bloodImage"
                    if (bloodImage != null)
                    {
                        Color imageColor = bloodImage.color;
                        imageColor.a = alpha;
                        bloodImage.color = imageColor;
                    }


                


            }
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (IsPlayer() && damage>0 && (currentHealth >= nearDeathValue))
        {

                ShowBloodPanel();
            
            
        }

        if (currentHealth <= 0)
        {
            if (IsPlayer() && death ==false)
            {
                death = true;
                dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

                foreach (GameObject obj in dontDestroyObjects)
                {
                    // Wy³¹cz sam obiekt
                    Destroy(obj);
                }
                //Scene activeScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(sceneMenager2.currentScene);
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
        if (gameObject.tag == "Player")
        {
            return true;
        }
        else
            return false;
        //return (gameObject == player);
    }

    public void RestoreHealth(int healthToRestore)
    {
        if((currentHealth += healthToRestore) >= nearDeathValue && currentHealth<nearDeathValue)
        {
            // Zakoñcz animacjê
            canvasGroup.alpha = 0f;
            panelBlood.SetActive(false);
            ShowBloodPanel();
        }
        currentHealth += healthToRestore;
    }




    public void ShowBloodPanel()
    {
        // Upewnij siê, ¿e panelBlood jest ukryty na pocz¹tku
        panelBlood.SetActive(false);

        // Pobierz lub dodaj komponent CanvasGroup do paneluBlood
        canvasGroup = panelBlood.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = panelBlood.AddComponent<CanvasGroup>();
        }

        // Pobierz komponent RawImage z dziecka panelBlood
        bloodImage = panelBlood.GetComponentInChildren<RawImage>();

        // Zresetuj wartoœci przezroczystoœci i przerwij poprzedni¹ animacjê, jeœli by³a uruchomiona
        canvasGroup.alpha = 1f;
        StopAllCoroutines();

        // Wyœwietl panelBlood
        panelBlood.SetActive(true);

        // Rozpocznij animacjê zmiany przezroczystoœci
        StartCoroutine(FadeBloodImage());
    }

    private System.Collections.IEnumerator FadeBloodImage()
    {
        // OpóŸnij animacjê
        yield return new WaitForSeconds(fadeDelay);

        // Oblicz czas dla pojedynczej klatki animacji
        float frameDuration = fadeDuration / 60f;

        // Wykonuj animacjê zmiany przezroczystoœci w pêtli
        for (float time = fadeDuration; time > 0f; time -= frameDuration)
        {
            // Oblicz now¹ wartoœæ przezroczystoœci w oparciu o czas
            float alpha = time / fadeDuration;

            // Ustaw now¹ wartoœæ przezroczystoœci dla CanvasGroup paneluBlood
            canvasGroup.alpha = alpha;

            // Ustaw now¹ wartoœæ przezroczystoœci dla obrazu "bloodImage"
            if (bloodImage != null)
            {
                Color imageColor = bloodImage.color;
                imageColor.a = alpha;
                bloodImage.color = imageColor;
            }

            // Poczekaj na kolejn¹ klatkê
            yield return new WaitForSeconds(frameDuration);
        }

        // Zakoñcz animacjê
        canvasGroup.alpha = 0f;
        panelBlood.SetActive(false);
    }
}
