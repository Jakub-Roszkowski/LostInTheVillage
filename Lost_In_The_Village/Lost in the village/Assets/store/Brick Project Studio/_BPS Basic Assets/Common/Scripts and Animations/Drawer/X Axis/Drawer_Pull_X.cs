using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{

    public class Drawer_Pull_X : MonoBehaviour
    {

        public string promptMessage;
        private string text;
        public Animator pull_01;
        public bool open;
        private Transform Player;

        void Start()
        {
            open = false;
        }

        public void Interact()
        {

            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Otworz / Zamknij (E)";
                    break;
                case Language_enum.English:
                    text = "Open / Close (E)";
                    break;
                case Language_enum.German:
                    text = "Öffnen / Schließen (E)";
                    break;
                case Language_enum.Spain:
                    text = "Abrir / Cerrar (E)";
                    break;
            }

            promptMessage = text;

        }
        public void Interact2()
        {
            if (open == false)
            {
                StartCoroutine(opening());
            }
            else
            {
                if (open == true)
                {

                    StartCoroutine(closing());
                }

            }
        }

        IEnumerator opening()
        {
            print("you are opening the door");
            pull_01.Play("openpull_01");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the door");
            pull_01.Play("closepush_01");
            open = false;
            yield return new WaitForSeconds(.5f);
        }


    }
}