using LostInTheVillage.Helpers.Translations;
using LostInTheVillage.Interactable.Interface;
using System.Collections;
using UnityEngine;

namespace SojaExiles
{
    public class ClosetopencloseDoor : AbstractInteractableObject
    {
        public string promptMessageTemp;

        public Animator Closetopenandclose;
        public bool open;

        void Start()
        {
            open = false;
        }

        protected override void Interact()
        {
            promptMessageTemp = LanguagesTranslation.SetTextOpenClose();
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
            Closetopenandclose.Play("ClosetOpening");
            open = true;
            yield return new WaitForSeconds(.5f);
        }
        IEnumerator closing()
        {
            print("you are closing the door");
            Closetopenandclose.Play("ClosetClosing");
            open = false;
            yield return new WaitForSeconds(.5f);
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}