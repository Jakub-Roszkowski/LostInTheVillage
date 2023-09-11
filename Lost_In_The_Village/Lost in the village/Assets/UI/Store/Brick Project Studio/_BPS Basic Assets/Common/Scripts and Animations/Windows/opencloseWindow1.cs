using LostInTheVillage.Interactable.Interface;
using System.Collections;
using UnityEngine;

namespace SojaExiles
{
    public class opencloseWindow1 : AbstractInteractableObject
    {
        public string promptMessageTemp;

        public Animator openandclosewindow1;
        public bool open;

        void Start()
        {
            open = false;
        }

        protected override void Interact()
        {
            promptMessageTemp = LostInTheVillage.Helpers.Languages.SetTextOpenClose();
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
            print("you are opening the Window");
            openandclosewindow1.Play("Openingwindow 1");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the Window");
            openandclosewindow1.Play("Closingwindow 1");
            open = false;
            yield return new WaitForSeconds(.5f);
        }

        protected override string PromptMessage()
        {
            return promptMessageTemp;
        }
    }
}