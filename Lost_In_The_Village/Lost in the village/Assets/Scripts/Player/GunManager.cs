using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField] private GameObject weapon1;
    [SerializeField] private GameObject weapon2;
    [SerializeField] private GameObject weapon3;
    [SerializeField] private GameObject weapon4;
    [SerializeField] private GameObject currentWeapon;

    [SerializeField] private GameObject weapon2Panel;
    [SerializeField] private GameObject weapon3Panel;
    [SerializeField] private GameObject weapon4Panel;

    public PlayerInput.OnFootActions onFoot;

    private PlayerInput playerInput;

    private bool weapon1Available = true;
    private bool weapon2Available = false;
    private bool weapon3Available = false;
    private bool weapon4Available = false;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

    void Start()
    {
        currentWeapon = weapon1;
    }
    void Update()
    {
        if (onFoot.gun1.triggered && weapon1Available)
        {
            PickupWeapon("M4A1");
            DropWeapon("M4A1");
        }
        else if (onFoot.gun2.triggered && weapon2Available)
        {
            PickupWeapon("AK47");
            DropWeapon("AK47");
        }
        else if (onFoot.gun3.triggered && weapon3Available)
        {
            PickupWeapon("shotgun");
            DropWeapon("shotgun");
        }
        else if (onFoot.gun4.triggered && weapon4Available)
        {
            PickupWeapon("SMG");
            DropWeapon("SMG");
        }
    }
    public void PickupWeapon(string weapon)
    {
        if (weapon == "M4A1")
        {
            weapon1.SetActive(true);
            currentWeapon = weapon1;
        }
        else if (weapon == "AK47")
        {
            weapon2.SetActive(true);
            currentWeapon = weapon2;
            weapon2Available = true;
            weapon2Panel.SetActive(true);
        }
        else if (weapon == "shotgun")
        {
            weapon3.SetActive(true);
            currentWeapon = weapon3;
            weapon3Available = true;
            weapon3Panel.SetActive(true);
        }
        else if (weapon == "SMG")
        {
            weapon4.SetActive(true);
            currentWeapon = weapon4;
            weapon4Available = true;
            weapon4Panel.SetActive(true);
        }
    }

    public void DropWeapon(string weapon)
    {
        if (weapon == "M4A1")
        {
            weapon2.SetActive(false);
            weapon3.SetActive(false);
            weapon4.SetActive(false);
        }
        else if (weapon == "AK47")
        {
            weapon1.SetActive(false);
            weapon3.SetActive(false);
            weapon4.SetActive(false);
        }
        else if (weapon == "shotgun")
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon4.SetActive(false);
        }
        else if (weapon == "SMG")
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon3.SetActive(false);
        }
    }

    public bool IsTheSame(GameObject weapon)
    {
        if (weapon.CompareTag(currentWeapon.tag))
            return true;
        else return false;
    }
}
