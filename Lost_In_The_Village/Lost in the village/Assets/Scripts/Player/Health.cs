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

                // Upewnij si�, �e panelBlood jest ukryty na pocz�tku
                panelBlood.SetActive(false);

                // Pobierz lub dodaj komponent CanvasGroup do paneluBlood
                canvasGroup = panelBlood.GetComponent<CanvasGroup>();
                if (canvasGroup == null)
                {
                    canvasGroup = panelBlood.AddComponent<CanvasGroup>();
                }

                // Pobierz komponent RawImage z dziecka panelBlood
                bloodImage = panelBlood.GetComponentInChildren<RawImage>();

                // Zresetuj warto�ci przezroczysto�ci i przerwij poprzedni� animacj�, je�li by�a uruchomiona
                canvasGroup.alpha = 1f;
                StopAllCoroutines();

                // Wy�wietl panelBlood
                panelBlood.SetActive(true);

                // Oblicz czas dla pojedynczej klatki animacji
                float frameDuration = fadeDuration / 60f;

                // Wykonuj animacj� zmiany przezroczysto�ci w p�tli
                
                    // Oblicz now� warto�� przezroczysto�ci w oparciu o czas
                    float alpha = 0.7f;

                    // Ustaw now� warto�� przezroczysto�ci dla CanvasGroup paneluBlood
                    canvasGroup.alpha = alpha;

                    // Ustaw now� warto�� przezroczysto�ci dla obrazu "bloodImage"
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
                    // Wy��cz sam obiekt
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
            // Zako�cz animacj�
            canvasGroup.alpha = 0f;
            panelBlood.SetActive(false);
            ShowBloodPanel();
        }
        currentHealth += healthToRestore;
    }




    public void ShowBloodPanel()
    {
        // Upewnij si�, �e panelBlood jest ukryty na pocz�tku
        panelBlood.SetActive(false);

        // Pobierz lub dodaj komponent CanvasGroup do paneluBlood
        canvasGroup = panelBlood.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = panelBlood.AddComponent<CanvasGroup>();
        }

        // Pobierz komponent RawImage z dziecka panelBlood
        bloodImage = panelBlood.GetComponentInChildren<RawImage>();

        // Zresetuj warto�ci przezroczysto�ci i przerwij poprzedni� animacj�, je�li by�a uruchomiona
        canvasGroup.alpha = 1f;
        StopAllCoroutines();

        // Wy�wietl panelBlood
        panelBlood.SetActive(true);

        // Rozpocznij animacj� zmiany przezroczysto�ci
        StartCoroutine(FadeBloodImage());
    }

    private System.Collections.IEnumerator FadeBloodImage()
    {
        // Op�nij animacj�
        yield return new WaitForSeconds(fadeDelay);

        // Oblicz czas dla pojedynczej klatki animacji
        float frameDuration = fadeDuration / 60f;

        // Wykonuj animacj� zmiany przezroczysto�ci w p�tli
        for (float time = fadeDuration; time > 0f; time -= frameDuration)
        {
            // Oblicz now� warto�� przezroczysto�ci w oparciu o czas
            float alpha = time / fadeDuration;

            // Ustaw now� warto�� przezroczysto�ci dla CanvasGroup paneluBlood
            canvasGroup.alpha = alpha;

            // Ustaw now� warto�� przezroczysto�ci dla obrazu "bloodImage"
            if (bloodImage != null)
            {
                Color imageColor = bloodImage.color;
                imageColor.a = alpha;
                bloodImage.color = imageColor;
            }

            // Poczekaj na kolejn� klatk�
            yield return new WaitForSeconds(frameDuration);
        }

        // Zako�cz animacj�
        canvasGroup.alpha = 0f;
        panelBlood.SetActive(false);
    }
}
