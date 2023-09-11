using UnityEngine;

namespace LostInTheVillage.Headlamp
{
    public class Headlamp : MonoBehaviour
    {
        [SerializeField] private Light headLampLight;
        private InputManagerToHeadLamp inputManager;

        private bool ifActive = true;

        private void Start()
        {
            inputManager = GetComponent<InputManagerToHeadLamp>();
        }

        private void Update()
        {
            if (inputManager.OnFoot.Light.triggered)
            {
                headLampLight.gameObject.SetActive(!ifActive);
                ifActive = !ifActive;
            }
        }
    }
}
