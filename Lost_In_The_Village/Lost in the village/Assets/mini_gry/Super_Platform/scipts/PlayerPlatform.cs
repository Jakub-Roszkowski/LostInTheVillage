using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class PlayerPlatform : MonoBehaviour
{
    public bool grounded = true;
    public float jumpPower = 5500f;
    public float walkSpeed = 7;
    public Rigidbody2D rbody;
    public Animator animator;
    public Animator animator_new_lvl;
    public GameObject apple;
    public BoxCollider2D apppleBox;

    public GameObject new_lewel_obj;
    public BoxCollider2D new_lewelBox;

    public GameObject win_obj;
    public BoxCollider2D winBox;


    public GameObject PanelWIN;

    public AudioSource BGM;
    public AudioClip StartGame_sound;
    public AudioClip Jump_sound;
    public AudioClip levelUp_sound;
    public AudioClip WIN_sound;
    public AudioClip Death_sound;
    public AudioClip Coin_sound;
    public AudioClip demage_sound;
    public AudioClip powerup_sound;
    public AudioClip shooting_sound;

    public GameObject bulletobject;
    public Transform shootPoint;

    public TMP_Text Score_TMP;
    public TMP_Text Mute_TMP;
    public TMP_Text Time_TMP;

    public GameObject muteSounds_button;

    public static bool start = false;
    public static bool start_movement = false;

    private bool runningAnim = false;
    public static bool death = false;
    private bool new_level = false;
    public static bool win = false;
    private bool win_movement = false;
    private bool coin = false;
    private bool demage = false;
    private bool powerUP = false;
    private bool jump = false;
    public static int score = 0;
    private bool mute = false;

    public static string timeres = "";


    public static int health = 100;

    private int level = 0;



    System.DateTime time;
    public static System.DateTime timestart;


    private AudioSource audioSource;
    private float glosnosc;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        glosnosc = audioSource.volume;



        health = 100;
        death = false;
        start = false;
        runningAnim = false;
        new_level = false;
        win = false;
        win_movement = false;
        coin = false;
        demage = false;
        powerUP = false;
        jump = false;
        level = 0;
        start_movement = false;
        score = 0;

        defoultMovement();
        timeres = "";

        //timestart = DateTime.Now;
    }


    void Update()
    {
        if (!death && !win_movement && start_movement)
        {
            Movement();
            shooting();
        }
        runAminations();
        sounds();

        Restart_game();
        Finish_game();
        PanelInGame();

        if (win || death)
        {
            PanelWIN.SetActive(true);
        }
    }

    public void PanelInGame()
    {
        Score_TMP.text = score.ToString();


        //if (mute) Mute_TMP.text = "0";
        //else Mute_TMP.text = "1";

        //muteSounds_button.transform.GetComponent<Button>().onClick.AddListener(onClickButton);
        //if (Input.GetKeyDown(KeyCode.Joystick1Button4)) onClickButton();
        if (Pause.MusicisMute)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = glosnosc;
        }



        if (!win_movement && !death)
        {
            timeres = (DateTime.Now - timestart).Minutes.ToString() + ":" + (DateTime.Now - timestart).Seconds.ToString();
            Time_TMP.text = timeres;
        }
    }
    public void Restart_game()
    {
        if (Input.GetKeyDown(KeyCode.F8) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Retry();
        }
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
        {
            obj.SetActive(true);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Finish_game()
    {
        if (Input.GetKeyDown(KeyCode.F9) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Finish();
        }
    }

    public void Finish()
    {
        Time.timeScale = 1f;
        foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
        {
            obj.SetActive(true);
        }
        SceneManager.LoadScene("empty");
        if (!GameOpenerSuperPlatform.inGame)
        {
            MiniGameMenu.ingame2 = true;
        }
        else
        {
            GameOpenerSuperPlatform.inGame = false;
        }
    }

    public void defoultMovement()
    {
        jumpPower = 5500f;
        walkSpeed = 7;
    }

    void Movement()
    {

        //if (!grounded && rbody.velocity.y == 0)
        //{
        //	grounded = true;
        //}
        //w górê, skok
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Joystick1Button1)) && grounded == true)
        {
            rbody.AddForce(transform.up * jumpPower);
            jump = true;
        }

        //w lewo
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") < 0f)
        {

            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            if (transform.localScale.x > 0)
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }


        //w prawo
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0f)
        {

            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            if (transform.localScale.x < 0)
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") > 0f || Input.GetAxis("Horizontal") < 0f)
        {
            runningAnim = true;
        }
        else
        {
            runningAnim = false;
        }
    }








    void sounds()
    {
        if (death)
        {
            ChangeBGM(Death_sound);
        }
        else if (start)
        {
            ChangeBGM(StartGame_sound);
            start = false;
        }
        else if (new_level)
        {
            ChangeBGM(levelUp_sound);
            if (grounded) new_level = false;
        }
        else if (win)
        {
            ChangeBGM(WIN_sound);
        }
        else if (coin)
        {
            BGM.Stop();
            BGM.clip = Coin_sound;
            BGM.Play();
            coin = false;
        }
        else if (demage)
        {
            BGM.Stop();
            BGM.clip = demage_sound;
            BGM.Play();
            demage = false;
        }
        else if (powerUP)
        {
            ChangeBGM(powerup_sound);
            powerUP = false;
        }
        else if (jump)
        {
            ChangeBGM(Jump_sound);
            jump = false;
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = true;
        }
        if (collision.collider.CompareTag("JUMP"))
        {
            rbody.AddForce(transform.up * 10000f);
            jump = true;
        }
        if (collision.collider.CompareTag("Fire"))
        {
            death = true;
            health = 0;
        }
        if (collision.collider.CompareTag("coin"))
        {
            score++;
            coin = true;
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("spike"))
        {
            if (health >= 11) health = health - 10;
            else
            {
                health = 0;
                death = true;
                demage = true;
            }
            demage = true;

        }
        if (collision.collider == apppleBox)
        {
            powerUP = true;
            walkSpeed = walkSpeed * 2;
            jumpPower = jumpPower * (1.5f);
            Destroy(apple);
        }
        if (collision.collider == new_lewelBox)
        {
            new_level = true;
            Destroy(new_lewel_obj);
            defoultMovement();
            level++;
            animator_new_lvl.SetBool("new_level", true);
        }
        if (collision.collider == winBox)
        {
            win = true;
            win_movement = true;
            Destroy(win_obj);
            if (GameOpenerSuperPlatform.inGame)
            {
                GameOpenerSuperPlatform.finishGame = true;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = false;
        }
    }

    private void runAminations()
    {
        if (death)
        {
            animator.SetInteger("Anim", 3);
        }
        else if (!grounded)
        {
            animator.SetInteger("Anim", 2);
        }
        else if (runningAnim)
        {
            animator.SetInteger("Anim", 1);
        }
        else animator.SetInteger("Anim", 0);


    }



    public void ChangeBGM(AudioClip music)
    {

        if (BGM.clip.name != Jump_sound.name)
        {
            if (BGM.clip.name == music.name)
                return;
        }




        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    private void onClickButton()
    {
        if (!mute)
        {
            BGM.volume = 0f;
            mute = true;
        }

        else
        {
            BGM.volume = 100f;
            mute = false;
        }
    }

    private void shooting()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            var newBullet = Instantiate(bulletobject) as GameObject;
            newBullet.transform.position = shootPoint.position;
            newBullet.transform.rotation = transform.rotation;
            newBullet.transform.rotation = transform.rotation;

            if (shootPoint.position.x <= transform.position.x)
            {
                newBullet.transform.Rotate(0, 0, 180);
            }

            BGM.Stop();
            BGM.clip = shooting_sound;
            BGM.Play();
        }
    }
}