using LostInTheVillage.Helpers;
using LostInTheVillage.SceneHelpers.SceneMenager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LostInTheVillage.Player
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private GameObject panelBlood;
        [SerializeField] private float maxHealth = ConfigNumbers.DefaultMaxHp;

        private static GameObject[] dontDestroyObjects;
        private float fadeDuration = 1f;
        private float fadeDelay = 0.5f;

        private CanvasGroup canvasGroup;
        private RawImage bloodImage;

        private int nearDeathValue = ConfigNumbers.NearDeathHPValue;
        private bool death = false;
        private float currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
            death = false;
        }
        public float GetCurrentHealth()
        {
            return currentHealth;
        }
        public void TakeDamage(float damage)
        {
            currentHealth -= damage;
            if (IsPlayer())
            {
                if (damage > 0 && (currentHealth >= nearDeathValue))
                {
                    ShowBloodPanel();
                }

                else if (currentHealth < nearDeathValue)
                {
                    ShowBloodPanelWhenHPIsLow();
                }
            }

            if (currentHealth <= 0)
            {
                if (IsPlayer() && death == false)
                {
                    death = true;
                    dontDestroyObjects = GameObject.FindGameObjectsWithTag("DontDestroyOnLoad");

                    foreach (GameObject obj in dontDestroyObjects)
                    {
                        Destroy(obj);
                    }
                    SceneManager.LoadScene(SceneMenager2.CurrentScene);
                }
                else if (!IsPlayer())
                {
                    Animator animator = this.GetComponent<Animator>();
                    animator.SetBool("isDead", true);
                }
            }
        }



        public void RestoreHealth(int healthToRestore)
        {
            if ((currentHealth + healthToRestore) >= nearDeathValue && currentHealth < 100)
            {
                canvasGroup.alpha = 0f;
                panelBlood.SetActive(false);
                ShowBloodPanel();
            }
            currentHealth += healthToRestore;
            if (currentHealth > maxHealth)
                currentHealth = maxHealth;
        }

        //this is using in animation Die
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

        #region BloodPanel

        public void ShowBloodPanelWhenHPIsLow()
        {
            ShowBloodPanelHandle();

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

        public void ShowBloodPanel()
        {
            ShowBloodPanelHandle();
            StartCoroutine(FadeBloodImage());
        }

        public void ShowBloodPanelHandle()
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
        #endregion
    }
}