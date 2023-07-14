using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum Place_enum
{
    Welcome_Village2,
    Bar1,
    Bar2,
    Roszkol1,
    Roszkol2,
    Orzel_welcome,
    Orzel_glasses,
    Orzel_tunel,
    Orzel_laptop,
}

public class CharacterMessage : MonoBehaviour
{

    public TextMeshProUGUI promptText;
    public TextMeshProUGUI destination;
    public Place_enum place;
    public AudioSource BGM;

    public static bool isMusicDown = false;


    public AudioClip Welcome_Village2_PL;
    public AudioClip Welcome_Village2_EN;
    public AudioClip Welcome_Village2_GER;
    public AudioClip Welcome_Village2_SPA;

    public AudioClip Bar1_PL;
    public AudioClip Bar1_EN;
    public AudioClip Bar1_GER;
    public AudioClip Bar1_SPA;

    public AudioClip Bar2_PL;
    public AudioClip Bar2_EN;
    public AudioClip Bar2_GER;
    public AudioClip Bar2_SPA;

    public AudioClip Roszkol1_PL;
    public AudioClip Roszkol1_EN;
    public AudioClip Roszkol1_GER;
    public AudioClip Roszkol1_SPA;

    public AudioClip Roszkol2_PL;
    public AudioClip Roszkol2_EN;
    public AudioClip Roszkol2_GER;
    public AudioClip Roszkol2_SPA;

    public AudioClip Orzel_welcome_PL;
    public AudioClip Orzel_welcome_EN;
    public AudioClip Orzel_welcome_GER;
    public AudioClip Orzel_welcome_SPA;

    public AudioClip Orzel_glasses_PL;
    public AudioClip Orzel_glasses_EN;
    public AudioClip Orzel_glasses_GER;
    public AudioClip Orzel_glasses_SPA;

    public AudioClip Orzel_tunel_PL;
    public AudioClip Orzel_tunel_EN;
    public AudioClip Orzel_tunel_GER;
    public AudioClip Orzel_tunel_SPA;

    public AudioClip Orzel_laptop_PL;
    public AudioClip Orzel_laptop_EN;
    public AudioClip Orzel_laptop_GER;
    public AudioClip Orzel_laptop_SPA;






    private string str_Welcome_Village2_PL = "Ahh te okropne miasto. Jak widzisz pojawiły się wrogie roboty. Tylko Orzeł może nas uratować. Ostatni raz widziałem go w domu alkoholików. To jest na ulicy Cichej 4";
    private string str_Welcome_Village2_EN = "Ahh this horrible city. As you can see, hostile robots have appeared. Only the Eagle can save us. The last time I saw him was at an alcoholic's home. This is on Quiet 4 Street";
    private string str_Welcome_Village2_GER = "Ahh, diese schreckliche Stadt. Wie Sie sehen können, sind feindliche Roboter aufgetaucht. Nur der Adler kann uns retten. Das letzte Mal, dass ich ihn sah, war bei einem Alkoholiker zu Hause. Es liegt in der Ruhige-Straße 4.";
    private string str_Welcome_Village2_SPA = "Ahh esta horrible ciudad. Como puede ver, han aparecido robots hostiles. Sólo el Águila puede salvarnos. La última vez que lo vi fue en la casa de un alcohólico. Esto es en la calle Tranquila 4";

    private string str_Bar1_PL = "Witaj w moim barze! Jasne, że wiem, gdzie może być orzeł, ale najpierw musisz spróbować mojego wina.";
    private string str_Bar1_EN = "Welcome to my bar! Sure, I know where the eagle might be, but first you have to taste my wine.";
    private string str_Bar1_GER = "Willkommen in meiner Bar! Klar, ich weiß, wo der Adler sein könnte, aber zuerst musst du meinen Wein probieren.";
    private string str_Bar1_SPA = "¡Bienvenido a mi bar! Claro, sé dónde podría estar el águila, pero primero tienes que probar mi vino.";

    private string str_Bar2_PL = "Mam nadzieję, że smakowało. Roszkol może wiedzieć, gdzie jest Orzeł. Mieszka on przy ulicy Parkowej 4. Wpadnij jeszcze do mnie na wyższe piętra.";
    private string str_Bar2_EN = "I hope it tasted good. Roszkol may know where the Eagle is. He lives at 4 Parks Street. Come and visit me sometimes on the upper floors.";
    private string str_Bar2_GER = "Ich hoffe, es hat gut geschmeckt. Roszkol weiß vielleicht, wo der Adler ist. Er wohnt in der Parkstraße 4. Besuchen Sie mich manchmal in den oberen Etagen.";
    private string str_Bar2_SPA = "Espero que supiera bien. Roszkol puede saber dónde está el Águila. Vive en la calle Parque 4. Ven a visitarme a los pisos superiores.";

    private string str_Roszkol1_PL = "Witam serdecznie w moich skromnych progach. Szukasz Orła? Zaraz ci powiem, gdzie mieszka, ale najpierw proszę, nakarm mojego psa. Śpi gdzieś na łóżku.";
    private string str_Roszkol1_EN = "Welcome to my humble home. Looking for an Eagle? I'll tell you where he lives in a minute, but first, please, feed my dog. He's sleeping on a bed somewhere.";
    private string str_Roszkol1_GER = "Willkommen in meinem bescheidenen Zuhause. Auf der Suche nach einem Adler? Ich werde Ihnen gleich sagen, wo er wohnt, aber zuerst füttern Sie bitte meinen Hund. Er schläft irgendwo auf einem Bett.";
    private string str_Roszkol1_SPA = "Bienvenidos a mi humilde hogar. ¿Buscas un águila? Te diré dónde vive en un minuto, pero primero, por favor, alimenta a mi perro. Está durmiendo en una cama en alguna parte.";

    private string str_Roszkol2_PL = "Dzięki wielkie za usługę. Orzeł jest przy ulicy Namiotowej 21. Powodzenia!";
    private string str_Roszkol2_EN = "Thanks a lot for the service. The eagle is at 21 Tent Street. Good luck!";
    private string str_Roszkol2_GER = "Vielen Dank für den Service. Der Adler befindet sich in der Zeltstraße 21. Viel Glück!";
    private string str_Roszkol2_SPA = "Muchas gracias por el servicio. El águila está en Tent Street 21. ¡Buena suerte!";

    private string str_Orzel_welcome_PL = "Siema! Ale wczoraj zachlałem! Trzeba jak najszybciej wyłączyć te roboty, ale na PWR zgubiłem okulary. Chodźmy jak najszybciej ich poszukać!";
    private string str_Orzel_welcome_EN = "Hiya! I have a big hangover! We need to disable these robots as soon as possible, but I lost my glasses at PWR. Let's go look for them as soon as possible!";
    private string str_Orzel_welcome_GER = "Hallo! Ich habe einen großen Kater! Wir müssen diese Roboter so schnell wie möglich außer Gefecht setzen, aber ich habe meine Brille bei PWR verloren. Lasst uns so schnell wie möglich nach ihnen suchen!";
    private string str_Orzel_welcome_SPA = "¡Hola! ¡Tengo una gran resaca! Necesitamos desactivar estos robots lo antes posible, pero perdí mis anteojos en PWR. ¡Vamos a buscarlos lo antes posible!";

    private string str_Orzel_glasses_PL = "O, dziękuję bardzo, ale na Politechnice zalało serwery. Trzeba jak najszybciej włączyć kopię zapasową. Włącznik znajduje się w tunelu przy ulicy Cichej, między pierwszym a drugim domem.";
    private string str_Orzel_glasses_EN = "Oh, thank you very much, but the servers at the University of Technology were flooded. You need to enable backup as soon as possible. The switch is in the tunnel on Quiet Street, between the first and second house.";
    private string str_Orzel_glasses_GER = "Oh, vielen Dank, aber die Server der Technischen Universität waren überlastet. Sie müssen die Sicherung so schnell wie möglich aktivieren. Der Schalter befindet sich im Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus.";
    private string str_Orzel_glasses_SPA = "Oh, muchas gracias, pero los servidores de la Universidad Tecnológica se inundaron. Debe habilitar la copia de seguridad lo antes posible. El interruptor está en el túnel de la calle Tranquila, entre la primera y la segunda casa.";

    private string str_Orzel_tunel_PL = "Trochę tu ciemno, chodźmy do parku.";
    private string str_Orzel_tunel_EN = "It's a little dark in here, let's go to the park.";
    private string str_Orzel_tunel_GER = "Es ist etwas dunkel hier drin, lass uns in den Park gehen.";
    private string str_Orzel_tunel_SPA = "Está un poco oscuro aquí, vamos al parque.";

    private string str_Orzel_laptop_PL = "Bug został naprawiony błyskawicznie. Nareszcie mogę opuścić te miasto. Odprowadź mnie do bram miasta.";
    private string str_Orzel_laptop_EN = "The bug was fixed quickly. I can finally leave this town. Walk me to the city gates.";
    private string str_Orzel_laptop_GER = "Der Fehler wurde schnell behoben. Endlich kann ich diese Stadt verlassen. Begleite mich zu den Toren der Stadt.";
    private string str_Orzel_laptop_SPA = "El error se solucionó rápidamente. Finalmente puedo dejar esta ciudad. Llévame a las puertas de la ciudad.";





    private string str2_Welcome_Village2_PL = "Cicha 4";
    private string str2_Welcome_Village2_EN = "Quiet 4 Street";
    private string str2_Welcome_Village2_GER = "Ruhige-Straße 4";
    private string str2_Welcome_Village2_SPA = "calle Tranquila 4";

    private string str2_Bar1_PL = "Napij się wina";
    private string str2_Bar1_EN = "Drink some wine";
    private string str2_Bar1_GER = "Trink etwas Wein";
    private string str2_Bar1_SPA = "Toma un poco de vino";

    private string str2_Bar2_PL = "Parkowa 4";
    private string str2_Bar2_EN = "4 Parks Street";
    private string str2_Bar2_GER = "Parkstraße 4";
    private string str2_Bar2_SPA = "la calle Parque 4";

    private string str2_Roszkol1_PL = "Pies na łóżku";
    private string str2_Roszkol1_EN = "The dog on the bed";
    private string str2_Roszkol1_GER = "Der Hund auf dem Bett";
    private string str2_Roszkol1_SPA = "El perro en la cama";

    private string str2_Roszkol2_PL = "Namiotowa 21";
    private string str2_Roszkol2_EN = "21 Tent Street";
    private string str2_Roszkol2_GER = "Zeltstraße 21";
    private string str2_Roszkol2_SPA = "Tent Street 21";

    private string str2_Orzel_welcome_PL = "PWR - Niemiecka";
    private string str2_Orzel_welcome_EN = "PWR - German";
    private string str2_Orzel_welcome_GER = "PWR - Deutsch";
    private string str2_Orzel_welcome_SPA = "PWR - Alemán";

    private string str2_Orzel_glasses_PL = "tunel przy ulicy Cichej między pierwszym a drugim domem";
    private string str2_Orzel_glasses_EN = "the tunnel on Quiet Street, between the first and second house";
    private string str2_Orzel_glasses_GER = "Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus";
    private string str2_Orzel_glasses_SPA = "el túnel de la calle Tranquila, entre la primera y la segunda casa";

    private string str2_Orzel_tunel_PL = "Laptop w Parku";
    private string str2_Orzel_tunel_EN = "Laptop in the Park";
    private string str2_Orzel_tunel_GER = "Laptop im Park";
    private string str2_Orzel_tunel_SPA = "Laptop en el parque";

    private string str2_Orzel_laptop_PL = "Bramy miasta";
    private string str2_Orzel_laptop_EN = "City gates";
    private string str2_Orzel_laptop_GER = "Stadttore";
    private string str2_Orzel_laptop_SPA = "puertas de la ciudad";

    public AudioClip audio;
    private string promptString;
    private string destinationString;


    private Transform cameraTransform;
    private Quaternion initialRotation;
    private bool isRotating = false;
    private float rotationSpeed = 2f;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mainCamera = GameObject.FindWithTag("MainCamera");
        if (mainCamera != null)
        {
            cameraTransform = mainCamera.transform;
        }
        initialRotation = transform.rotation;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMusicDown)
        {
            if (cameraTransform != null)
            {
                // Oblicz kierunek patrzenia postaci tylko dla osi Y
                Vector3 lookDirection = cameraTransform.position - transform.position;
                lookDirection.y = 0f; // Wyzeruj składową Y, aby obrót był tylko dla osi Y

                // Obróć postać tylko dla osi Y zachowując pozostałe składowe obrotu
                Quaternion targetRotation = Quaternion.LookRotation(lookDirection.normalized, transform.up);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            }
        }
        else
        {
            // Płynnie wróć do początkowej rotacji
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, rotationSpeed * Time.deltaTime);

            // Sprawdź, czy bliskość początkowej rotacji jest wystarczająca
            if (Quaternion.Angle(transform.rotation, initialRotation) < 1f)
            {
                transform.rotation = initialRotation; // Ustaw dokładną początkową rotację
                isRotating = false; // Zatrzymaj rotację
            }
        }
    }

    public void Message()
    {
        Select();

        destination.text = destinationString;

        ChangeBGM(audio);
        StartCoroutine(waitingFun(audio.length));




    }
    IEnumerator waitingFun(float time1)
    {
        isMusicDown = true;
        promptText.text = promptString;
        animator.SetBool("is_talk", true);
        yield return new WaitForSeconds(time1);
        animator.SetBool("is_talk", false);
        yield return new WaitForSeconds(2.0f);
        promptText.text = "";
        isMusicDown = false;

        if (place == Place_enum.Bar1)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination();
            Debug.Log("ide");
        }
        else if (place == Place_enum.Bar2)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination2();
            Debug.Log("ide");
        }
    }

    private void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();

    }


    private void Select()
    {
        switch (place)
        {
            case Place_enum.Welcome_Village2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Welcome_Village2_PL;
                        promptString = str_Welcome_Village2_PL;
                        destinationString = str2_Welcome_Village2_PL;
                        break;
                    case Language_enum.English:
                        audio = Welcome_Village2_EN;
                        promptString = str_Welcome_Village2_EN;
                        destinationString = str2_Welcome_Village2_EN;
                        break;
                    case Language_enum.German:
                        audio = Welcome_Village2_GER;
                        promptString = str_Welcome_Village2_GER;
                        destinationString = str2_Welcome_Village2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Welcome_Village2_SPA;
                        promptString = str_Welcome_Village2_SPA;
                        destinationString = str2_Welcome_Village2_SPA;
                        break;
                }
                break;
            case Place_enum.Bar1:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Bar1_PL;
                        promptString = str_Bar1_PL;
                        destinationString = str2_Bar1_PL;
                        break;
                    case Language_enum.English:
                        audio = Bar1_EN;
                        promptString = str_Bar1_EN;
                        destinationString = str2_Bar1_EN;
                        break;
                    case Language_enum.German:
                        audio = Bar1_GER;
                        promptString = str_Bar1_GER;
                        destinationString = str2_Bar1_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Bar1_SPA;
                        promptString = str_Bar1_SPA;
                        destinationString = str2_Bar1_SPA;
                        break;
                }
                break;
            case Place_enum.Bar2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Bar2_PL;
                        promptString = str_Bar2_PL;
                        destinationString = str2_Bar2_PL;
                        break;
                    case Language_enum.English:
                        audio = Bar2_EN;
                        promptString = str_Bar2_EN;
                        destinationString = str2_Bar2_EN;
                        break;
                    case Language_enum.German:
                        audio = Bar2_GER;
                        promptString = str_Bar2_GER;
                        destinationString = str2_Bar2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Bar2_SPA;
                        promptString = str_Bar2_SPA;
                        destinationString = str2_Bar2_SPA;
                        break;
                }
                break;
            case Place_enum.Roszkol1:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Roszkol1_PL;
                        promptString = str_Roszkol1_PL;
                        destinationString = str2_Roszkol1_PL;
                        break;
                    case Language_enum.English:
                        audio = Roszkol1_EN;
                        promptString = str_Roszkol1_EN;
                        destinationString = str2_Roszkol1_EN;
                        break;
                    case Language_enum.German:
                        audio = Roszkol1_GER;
                        promptString = str_Roszkol1_GER;
                        destinationString = str2_Roszkol1_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Roszkol1_SPA;
                        promptString = str_Roszkol1_SPA;
                        destinationString = str2_Roszkol1_SPA;
                        break;
                }
                break;
            case Place_enum.Roszkol2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Roszkol2_PL;
                        promptString = str_Roszkol2_PL;
                        destinationString = str2_Roszkol2_PL;
                        break;
                    case Language_enum.English:
                        audio = Roszkol2_EN;
                        promptString = str_Roszkol2_EN;
                        destinationString = str2_Roszkol2_EN;
                        break;
                    case Language_enum.German:
                        audio = Roszkol2_GER;
                        promptString = str_Roszkol2_GER;
                        destinationString = str2_Roszkol2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Roszkol2_SPA;
                        promptString = str_Roszkol2_SPA;
                        destinationString = str2_Roszkol2_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_welcome:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_welcome_PL;
                        promptString = str_Orzel_welcome_PL;
                        destinationString = str2_Orzel_welcome_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_welcome_EN;
                        promptString = str_Orzel_welcome_EN;
                        destinationString = str2_Orzel_welcome_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_welcome_GER;
                        promptString = str_Orzel_welcome_GER;
                        destinationString = str2_Orzel_welcome_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_welcome_SPA;
                        promptString = str_Orzel_welcome_SPA;
                        destinationString = str2_Orzel_welcome_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_glasses:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_glasses_PL;
                        promptString = str_Orzel_glasses_PL;
                        destinationString = str2_Orzel_glasses_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_glasses_EN;
                        promptString = str_Orzel_glasses_EN;
                        destinationString = str2_Orzel_glasses_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_glasses_GER;
                        promptString = str_Orzel_glasses_GER;
                        destinationString = str2_Orzel_glasses_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_glasses_SPA;
                        promptString = str_Orzel_glasses_SPA;
                        destinationString = str2_Orzel_glasses_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_tunel:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_tunel_PL;
                        promptString = str_Orzel_tunel_PL;
                        destinationString = str2_Orzel_tunel_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_tunel_EN;
                        promptString = str_Orzel_tunel_EN;
                        destinationString = str2_Orzel_tunel_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_tunel_GER;
                        promptString = str_Orzel_tunel_GER;
                        destinationString = str2_Orzel_tunel_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_tunel_SPA;
                        promptString = str_Orzel_tunel_SPA;
                        destinationString = str2_Orzel_tunel_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_laptop:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_laptop_PL;
                        promptString = str_Orzel_laptop_PL;
                        destinationString = str2_Orzel_laptop_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_laptop_EN;
                        promptString = str_Orzel_laptop_EN;
                        destinationString = str2_Orzel_laptop_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_laptop_GER;
                        promptString = str_Orzel_laptop_GER;
                        destinationString = str2_Orzel_laptop_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_laptop_SPA;
                        promptString = str_Orzel_laptop_SPA;
                        destinationString = str2_Orzel_laptop_SPA;
                        break;
                }
                break;
        }
    }
}
