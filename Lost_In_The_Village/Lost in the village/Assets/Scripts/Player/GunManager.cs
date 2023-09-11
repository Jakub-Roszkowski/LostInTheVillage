using UnityEngine;

namespace LostInTheVillage.Player
{
    public class GunManager : MonoBehaviour
    {
        [SerializeField] private GameObject weapon1;
        [SerializeField] private GameObject weapon2;
        [SerializeField] private GameObject weapon3;
        [SerializeField] private GameObject weapon4;

        [SerializeField] private GameObject weapon2Panel;
        [SerializeField] private GameObject weapon3Panel;
        [SerializeField] private GameObject weapon4Panel;

        private PlayerInput.OnFootActions onFoot;

        private PlayerInput playerInput;
        private GameObject currentWeapon;

        private bool weapon1Available = true;
        private bool weapon2Available = false;
        private bool weapon3Available = false;
        private bool weapon4Available = false;

        private void Awake()
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
            HandleWeaponSwitchingInput();
        }

        private void HandleWeaponSwitchingInput()
        {
            if (onFoot.gun1.triggered && weapon1Available)
            {
                SwitchToWeapon(weapon1);
            }
            else if (onFoot.gun2.triggered && weapon2Available)
            {
                SwitchToWeapon(weapon2);
            }
            else if (onFoot.gun3.triggered && weapon3Available)
            {
                SwitchToWeapon(weapon3);
            }
            else if (onFoot.gun4.triggered && weapon4Available)
            {
                SwitchToWeapon(weapon4);
            }
        }

        private void SwitchToWeapon(GameObject weapon)
        {
            currentWeapon.SetActive(false);
            weapon.SetActive(true);
            currentWeapon = weapon;

            weapon2Panel.SetActive(weapon2Available);
            weapon3Panel.SetActive(weapon3Available);
            weapon4Panel.SetActive(weapon4Available);
        }

        public void PickupWeapon(string weapon)
        {
            if (weapon == "M4A1")
            {
                SwitchToWeapon(weapon1);
            }
            else if (weapon == "AK47")
            {
                weapon2Available = true;
                SwitchToWeapon(weapon2);
            }
            else if (weapon == "shotgun")
            {
                weapon3Available = true;
                SwitchToWeapon(weapon3);
            }
            else if (weapon == "SMG")
            {
                weapon4Available = true;
                SwitchToWeapon(weapon4);
            }
        }

        public bool IsTheSame(GameObject weapon)
        {
            if (weapon.CompareTag(currentWeapon.tag))
                return true;
            else return false;
        }
    }
}