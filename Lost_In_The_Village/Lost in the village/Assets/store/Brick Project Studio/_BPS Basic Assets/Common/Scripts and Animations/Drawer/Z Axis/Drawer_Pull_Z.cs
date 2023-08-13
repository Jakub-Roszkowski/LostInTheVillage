using System.Collections;
using UnityEngine;

namespace SojaExiles
{
    public class Drawer_Pull_Z : AbstractInteractableObject
    {
        public string promptMessageTemp;
        public Animator pull;
        public bool open;

        void Start()
        {
            open = false;
        }

        protected override void Interact()
        {
            promptMessageTemp = Helpers.Languages.SetTextOpenClose();
        }
        protected override void Interact2()
        {
            if (open == false)
            {
                StartCoroutine(opening());
            }
            else
            {
                StartCoroutine(closing());
            }
        }
        IEnumerator opening()
        {
            print("you are opening the door");
            pull.Play("openpull");
            open = true;
            yield return new WaitForSeconds(.5f);
        }
        IEnumerator closing()
        {
            print("you are closing the door");
            pull.Play("closepush");
            open = false;
            yield return new WaitForSeconds(.5f);
        }

        protected override string promptMessage()
        {
            return promptMessageTemp;
        }
    }
}