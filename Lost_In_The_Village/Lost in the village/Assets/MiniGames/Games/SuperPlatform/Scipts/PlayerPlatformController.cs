using LostInTheVillage.Interactable.StartSuperPlatform;
using LostInTheVillage.Menus;
using LostInTheVillage.MiniGames.RemoveDontDestroy;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LostInTheVillage.MiniGames.Games.SuperPlatform.Scripts
{
    public class PlayerPlatformController : MonoBehaviour
    {
        [SerializeField] private AudioSource BGM;
        [SerializeField] private AudioClip startGameSound;
        [SerializeField] private AudioClip jumpSound;
        [SerializeField] private AudioClip levelUpSound;
        [SerializeField] private AudioClip winSound;
        [SerializeField] private AudioClip deathSound;
        [SerializeField] private AudioClip coinSound;
        [SerializeField] private AudioClip demageSound;
        [SerializeField] private AudioClip powerUpSound;
        [SerializeField] private AudioClip shootingSound;

        [SerializeField] private Rigidbody2D rbody;

        [SerializeField] private Animator animator;
        [SerializeField] private Animator animator_new_lvl;

        [SerializeField] private GameObject apple;
        [SerializeField] private BoxCollider2D apppleBox;

        [SerializeField] private GameObject newLewelObj;
        [SerializeField] private BoxCollider2D newLewelBoxCollider;

        [SerializeField] private GameObject win_obj;
        [SerializeField] private BoxCollider2D winBox;

        [SerializeField] private GameObject PanelWIN;

        [SerializeField] private GameObject bulletObject;
        [SerializeField] private Transform shootPoint;

        [SerializeField] private TMP_Text scoreTMP;
        [SerializeField] private TMP_Text timeTMP;

        public static DateTime TimeStart { get; set; }

        public static bool IsStart { get; set; } = false;
        public static bool IsStartMovement { get; set; } = false;

        public static bool IsWin { get; private set; } = false;
        public static int Score { get; private set; } = 0;
        public static string Timeres { get; private set; } = "";
        public static int Health { get; private set; } = 100;

        private bool isDeath = false;
        private bool isGrounded = true;
        private float jumpPower = 5500f;
        private float walkSpeed = 7;

        private bool isRunningAnim = false;
        private bool isNewLevel = false;

        private bool isWinMovement = false;
        private bool isCoin = false;
        private bool isDemage = false;
        private bool isPowerUP = false;
        private bool isJump = false;

        private DateTime time;

        private AudioSource audioSource;
        private float volume;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
            volume = audioSource.volume;

            Health = 100;
            isDeath = false;
            IsStart = false;
            isRunningAnim = false;
            isNewLevel = false;
            IsWin = false;
            isWinMovement = false;
            isCoin = false;
            isDemage = false;
            isPowerUP = false;
            isJump = false;
            IsStartMovement = false;
            Score = 0;

            DefoultMovement();
            Timeres = "";
        }

        private void Update()
        {
            if (!isDeath && !isWinMovement && IsStartMovement)
            {
                Movement();
                Shooting();
            }
            RunAminations();
            Sounds();

            RestartGame();
            FinishGame();
            PanelInGame();

            if (IsWin || isDeath)
            {
                PanelWIN.SetActive(true);
            }
        }

        private void PanelInGame()
        {
            scoreTMP.text = Score.ToString();

            if (Pause.MusicIsMute)
            {
                audioSource.volume = 0f;
            }
            else
            {
                audioSource.volume = volume;
            }

            if (!isWinMovement && !isDeath)
            {
                Timeres = (DateTime.Now - TimeStart).Minutes.ToString() + ":" + (DateTime.Now - TimeStart).Seconds.ToString();
                timeTMP.text = Timeres;
            }
        }
        private void RestartGame()
        {
            if (Input.GetKeyDown(KeyCode.F8) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Retry();
            }
        }

        private void Retry()
        {
            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        private void FinishGame()
        {
            if (Input.GetKeyDown(KeyCode.F9) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Finish();
            }
        }

        private void Finish()
        {
            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            SceneManager.LoadScene(Helpers.Scenes.Empty);
            if (!GameOpenerSuperPlatform.IsInGame)
            {
                MiniGameMenu.IsInGame2 = true;
            }
            else
            {
                GameOpenerSuperPlatform.IsInGame = false;
            }
        }

        private void DefoultMovement()
        {
            jumpPower = 5500f;
            walkSpeed = 7;
        }

        private void Movement()
        {
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Joystick1Button1)) && isGrounded == true)
            {
                rbody.AddForce(transform.up * jumpPower);
                isJump = true;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") < 0f)
            {

                transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
                if (transform.localScale.x > 0)
                    transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0f)
            {

                transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
                if (transform.localScale.x < 0)
                    transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") > 0f || Input.GetAxis("Horizontal") < 0f)
            {
                isRunningAnim = true;
            }
            else
            {
                isRunningAnim = false;
            }
        }

        private void Sounds()
        {
            if (isDeath)
            {
                ChangeBGM(deathSound);
            }
            else if (IsStart)
            {
                ChangeBGM(startGameSound);
                IsStart = false;
            }
            else if (isNewLevel)
            {
                ChangeBGM(levelUpSound);
                if (isGrounded) isNewLevel = false;
            }
            else if (IsWin)
            {
                ChangeBGM(winSound);
            }
            else if (isCoin)
            {
                BGM.Stop();
                BGM.clip = coinSound;
                BGM.Play();
                isCoin = false;
            }
            else if (isDemage)
            {
                BGM.Stop();
                BGM.clip = demageSound;
                BGM.Play();
                isDemage = false;
            }
            else if (isPowerUP)
            {
                ChangeBGM(powerUpSound);
                isPowerUP = false;
            }
            else if (isJump)
            {
                ChangeBGM(jumpSound);
                isJump = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                isGrounded = true;
            }
            if (collision.collider.CompareTag("JUMP"))
            {
                rbody.AddForce(transform.up * 10000f);
                isJump = true;
            }
            if (collision.collider.CompareTag("Fire"))
            {
                isDeath = true;
                Health = 0;
            }
            if (collision.collider.CompareTag("coin"))
            {
                Score++;
                isCoin = true;
                Destroy(collision.gameObject);
            }
            if (collision.collider.CompareTag("spike"))
            {
                if (Health >= 11)
                {
                    Health = Health - 10;
                }
                else
                {
                    Health = 0;
                    isDeath = true;
                    isDemage = true;
                }
                isDemage = true;

            }
            if (collision.collider == apppleBox)
            {
                isPowerUP = true;
                walkSpeed = walkSpeed * 2;
                jumpPower = jumpPower * (1.5f);
                Destroy(apple);
            }
            if (collision.collider == newLewelBoxCollider)
            {
                isNewLevel = true;
                Destroy(newLewelObj);
                DefoultMovement();
                animator_new_lvl.SetBool("new_level", true);
            }
            if (collision.collider == winBox)
            {
                IsWin = true;
                isWinMovement = true;
                Destroy(win_obj);
                if (GameOpenerSuperPlatform.IsInGame)
                {
                    GameOpenerSuperPlatform.HasFinishedGame = true;
                }
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                isGrounded = false;
            }
        }

        private void RunAminations()
        {
            if (isDeath)
            {
                animator.SetInteger("Anim", 3);
            }
            else if (!isGrounded)
            {
                animator.SetInteger("Anim", 2);
            }
            else if (isRunningAnim)
            {
                animator.SetInteger("Anim", 1);
            }
            else animator.SetInteger("Anim", 0);
        }

        private void ChangeBGM(AudioClip music)
        {
            if (BGM.clip.name != jumpSound.name)
            {
                if (BGM.clip.name == music.name)
                    return;
            }

            BGM.Stop();
            BGM.clip = music;
            BGM.Play();
        }

        private void Shooting()
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button7))
            {
                var newBullet = Instantiate(bulletObject) as GameObject;
                newBullet.transform.position = shootPoint.position;
                newBullet.transform.rotation = transform.rotation;
                newBullet.transform.rotation = transform.rotation;

                if (shootPoint.position.x <= transform.position.x)
                {
                    newBullet.transform.Rotate(0, 0, 180);
                }

                BGM.Stop();
                BGM.clip = shootingSound;
                BGM.Play();
            }
        }
    }
}