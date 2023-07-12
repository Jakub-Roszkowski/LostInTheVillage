using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Question
{
    public string question { get; }
    public string answearA { get; }
    public string answearB { get; }
    public string answearC { get; }
    public string answearD { get; }
    public string answear { get; }

    public Question(string question, string answearA, string answearB, string answearC, string answearD, string answear)
    {
        this.question = question;
        this.answearA = answearA;
        this.answearB = answearB;
        this.answearC = answearC;
        this.answearD = answearD;
        this.answear = answear;
    }
}

public class test_milioneirs : MonoBehaviour
{
    public static int CurrentPosition = 1;
    public static string CurrentQuestion = "";
    public static string CurrentAnswearA = "";
    public static string CurrentAnswearB = "";
    public static string CurrentAnswearC = "";
    public static string CurrentAnswearD = "";
    public static string CurrentAnswear = "";
    public static ArrayList arrayList = new ArrayList();
    public static ArrayList hard1 = new ArrayList();
    public static ArrayList hard2 = new ArrayList();
    public static ArrayList hard3 = new ArrayList();
    public static ArrayList hard4 = new ArrayList();
    public static ArrayList hard5 = new ArrayList();
    public static ArrayList hard6 = new ArrayList();
    public static ArrayList hard7 = new ArrayList();
    public static ArrayList hard8 = new ArrayList();
    public static ArrayList hard9 = new ArrayList();
    public static ArrayList hard10 = new ArrayList();
    public static ArrayList hard11 = new ArrayList();
    public static ArrayList hard12 = new ArrayList();

    public static int guaranteedWIN = 0;
    public static int potentialWIN = 0;

    // Start is called before the first frame update
    void Start()
    {


        hard1.Add(new Question("Jaki kraj ma najwi�cej ludno�ci na �wiecie?", "A. USA", "B. Chiny", "C. Stany Zjednoczone", "D. Rosja", "B"));
        hard1.Add(new Question("Jaki ocean jest najwi�kszy na �wiecie?", "A. Spokojny", "B. Atlantycki", "C. Indyjski", "D. Arktyczny", "A"));
        hard1.Add(new Question("Jaki jest symbol chemiczny z�ota?", "A. Zn", "B. Fe", "C. Ag", "D. Au", "D"));
        hard2.Add(new Question("Kt�ra z tych planet jest najmniejsza w Uk�adzie S�onecznym?", "A. Neptun", "B. Wenus", "C. Mars", "D. Merkury", "D"));
        hard2.Add(new Question("Kt�ra rzeka jest najd�u�sza na �wiecie?", "A. Nil", "B. Amazonka", "C. Jangcy", "D. Missisipi", "A"));
        hard2.Add(new Question("Jaki jest symbol chemiczny tlenu?", "A. Tl", "B. O", "C. Te", "D. S", "B"));
        hard2.Add(new Question("Kt�ry kolor nie jest obecny na fladze Niemiec?", "A. Czerwony", "B. Czarny", "C. Z�oty", "D. Zielony", "D"));
        hard3.Add(new Question("Jaka jest stolica Chin?", "A. Szanghaj", "B. Pekin", "C. Hongkong", "D. Kanton", "B"));
        hard3.Add(new Question("Kt�ry z tych kraj�w nie graniczy z Niemcami?", "A. Szwajcaria", "B. Belgia", "C. Hiszpania", "D. Czechy", "C"));
        hard4.Add(new Question("Kt�ry z nast�puj�cych ocean�w jest najwi�kszy pod wzgl�dem powierzchni? ", "A. Ocean Indyjski", "B. Ocean Atlantycki", "C. Ocean Spokojny", "D. Ocean Arktyczny", "C"));
        hard4.Add(new Question("Kt�ry kraj jest najwi�kszym producentem ropy naftowej na �wiecie? ", "A. Arabia Saudyjska", "B. Rosja", "C. Stany Zjednoczone", "D. Chiny", "A"));
        hard4.Add(new Question("Jakie miasto jest stolic� Australii? ", "A. Sydney", "B. Melbourne", "C. Perth", "D. Canberra", "D"));
        hard5.Add(new Question("Kt�re z nast�puj�cych pa�stw nie graniczy z Rosj�? ", "A. Polska", "B. Korea Po�udniowa", "C. Finlandia", "D. Estonia", "B"));
        hard6.Add(new Question("Kt�ra z planet w Uk�adzie S�onecznym jest najwi�ksza pod wzgl�dem rozmiaru? ", "A. Wenus", "B. Neptun", "C. Jowisz", "D. Ziemia", "C"));
        hard7.Add(new Question("Kt�re z pa�stw posiada najwi�ksz� powierzchni� na �wiecie? ", "A. Kanada", "B. Chiny", "C. Rosja", "D. Australia", "C"));
        hard8.Add(new Question("Kt�re z pa�stw posiada najwi�cej ludno�ci w Europie? ", "A. Niemcy", "B. Wielka Brytania", "C. Rosja", "D. Francja", "C"));
        hard9.Add(new Question("Kt�ry z nast�puj�cych kontynent�w jest najmniejszy pod wzgl�dem powierzchni? ", "A. Europa", "B. Ameryka Po�udniowa", "C. Afryka", "D. Australia", "D"));
        hard10.Add(new Question("Kt�ra z planet Uk�adu S�onecznego ma najwi�cej ksi�yc�w?", "A. Jowisz", "B. Saturn", "C. Uran", "D. Neptun", "A"));
        hard11.Add(new Question("W jakim kraju narodzi� si� malarz Vincent van Gogh?", "A. Francja", "B. Niemcy", "C. Holandia", "D. W�ochy", "C"));
        hard11.Add(new Question("Kt�ry piosenkarz jest autorem utworu 'Thriller'?", "A. Michael Jackson", "B. Prince", "C. Elvis Presley", "D. Madonna", "A"));
        hard12.Add(new Question("Kt�re pa�stwo jest najwi�kszym producentem kawy na �wiecie?", "A. Brazylia", "B. Kolumbia", "C. Etiopia", "D. Wietnam", "A"));



        hard1.Add(new Question("Kt�ry z tych film�w zosta� wyre�yserowany przez Stevena Spielberga ?", "A.Forrest Gump", "B.Jurassic Park", "C.Titanic", "D.Gladiator", "B"));
        hard1.Add(new Question("Kt�ry z tych instrument�w jest strunowy?", "A.Tr�bka", "B.Gitara", "C.Perkusja", "D.Flet", "B"));
        hard2.Add(new Question("W kt�rym kraju znajduje si� Machu Picchu ?", "A.Chile", "B.Argentyna", "C.Peru", "D.Boliwia", "C"));
        hard2.Add(new Question("W kt�rym roku wybuch�a I wojna �wiatowa ?", "A. 1914", "B. 1916", "C. 1918", "D. 1920", "A"));
        hard2.Add(new Question("Kt�ry z tych znak�w zodiaku jest powi�zany z elementem wody?", "A.Rak", "B.Lew", "C.Waga", "D.Strzelec", "A"));
        hard3.Add(new Question("Kt�ry kraj jest najwi�kszym producentem wina na �wiecie?", "A.W�ochy", "B.Francja", "C.Hiszpania", "D.Australia", "A"));
        hard3.Add(new Question("Jak nazywa si� najwi�kszy archipelag na �wiecie ?", "A.Karaiby", "B.Hawaje", "C.Filipiny", "D.Indonezja", "D"));
        hard3.Add(new Question("W kt�rym roku mia�a miejsce katastrofa w elektrowni atomowej w Czarnobylu ?", "A. 1984", "B. 1986", "C. 1988", "D. 1990", "B"));
        hard4.Add(new Question("Kt�ry z tych kontynent�w ma najmniej mieszka�c�w ?", "A.Australia", "B.Europa", "C.Ameryka P�nocna", "D.Antarktyda", "D"));
        hard4.Add(new Question("Kt�ry z tych j�zyk�w jest napisany alfabetem cyrylic�?", "A.Rosyjski", "B.Grecki", "C.Chi�ski", "D.Arabski", "A"));
        hard4.Add(new Question("W kt�rym roku odkryto Ameryk� ?", "A. 1400", "B. 1492", "C. 1520", "D. 1600", "B"));
        hard5.Add(new Question("Kt�ry z tych s�ynnych malarzy by� Hiszpanem ?", "A.Claude Monet", "B.Vincent van Gogh", "C.Pablo Picasso", "D.Leonardo da Vinci", "C"));
        hard5.Add(new Question("Jak nazywa si� najwi�ksze jezioro w Ameryce Po�udniowej?", "A.Maracaibo", "B.Titicaca", "C.Poopo", "D.Argentino", "B"));
        hard5.Add(new Question("Kt�ry z tych kraj�w jest najmniejszy pod wzgl�dem powierzchni?", "A.San Marino", "B.Monako", "C.Nauru", "D.Malta", "B"));
        hard7.Add(new Question("W jakim kraju znajduje si� najwi�cej wulkan�w ?", "A.Indonezja", "B.Japonia", "C.Stany Zjednoczone", "D.W�ochy", "A"));
        hard7.Add(new Question("Kt�ry z tych ocean�w jest najmniejszy pod wzgl�dem powierzchni ?", "A.Spokojny", "B.Atlantycki", "C.Indyjski", "D.Po�udniowy", "D"));
        hard7.Add(new Question("W jakim kraju znajduje si� s�ynny zamek Neuschwanstein?", "A.Niemcy", "B.Austria", "C.Francja", "D.W�ochy", "A"));
        hard8.Add(new Question("Ile ko�ci ma doros�y cz�owiek ?", "A. 206", "B. 212", "C. 218", "D. 224", "A"));
        hard8.Add(new Question("Kt�ra z tych planet jest najbli�ej S�o�ca ?", "A.Wenus", "B.Mars", "C.Merkury", "D.Ziemia", "C"));
        hard9.Add(new Question("Kt�ra z tych g�rskich formacji znajduje si� w Afryce ?", "A.Alpy", "B.Andy", "C.Himalaje", "D.G�ry Rwenzori", "D"));
        hard9.Add(new Question("Jakie miasto jest stolic� Stan�w Zjednoczonych?", "A.Nowy Jork", "B.Los Angeles", "C.Chicago", "D.Waszyngton", "D"));
        hard9.Add(new Question("Kt�ry z tych aktor�w zagra� Jamesa Bonda w najwi�kszej liczbie film�w ?", "A.Sean Connery", "B.Roger Moore", "C.Pierce Brosnan", "D.Daniel Craig", "B"));
        hard10.Add(new Question("Jakie pa�stwo le�y na P�wyspie Apeni�skim?", "A.Grecja", "B.Hiszpania", "C.W�ochy", "D.Portugalia", "C"));
        hard10.Add(new Question("Kt�ry z tych kraj�w nie le�y w Europie?", "A.Serbia", "B.Rumunia", "C.Kazachstan", "D.Czarnog�ra", "C"));
        hard11.Add(new Question("Kt�ra z tych piramid jest najwi�ksza?", "A.Piramida Cheopsa", "B.Piramida Mykerinosa", "C.Piramida Chefrena", "D.Piramida Amenemhata III", "A"));
        hard12.Add(new Question("Kt�ra z tych dru�yn pi�karskich ma siedzib� w Londynie ?", "A.Arsenal", "B.Manchester United", "C.Liverpool", "D.Everton", "A"));












































        CurrentPosition = 1;
        /*
                arrayList.Add(hard1);
                arrayList.Add(hard2);
                arrayList.Add(hard3);
                arrayList.Add(hard4);
                arrayList.Add(hard5);
                arrayList.Add(hard6);
                arrayList.Add(hard7);
                arrayList.Add(hard8);
                arrayList.Add(hard9);
                arrayList.Add(hard10);
                arrayList.Add(hard11);
                arrayList.Add(hard12);


                string[] lines = System.IO.File.ReadAllLines(Application.streamingAssetsPath+"/baza.txt");


                foreach (var item in lines) {
                    string[] line = item.Split(";");
                    Question question = new Question(System.Convert.ToInt32(line[0]), line[1], line[2], line[3], line[4], line[5], System.Convert.ToString(line[6]).Trim());


                    switch (question.hard)
                    {
                        case 1:
                            hard1.Add(question);
                            break;
                        case 2:
                            hard2.Add(question);
                            break;
                        case 3:
                            hard3.Add(question);
                            break;
                        case 4:
                            hard4.Add(question);
                            break;
                        case 5:
                            hard5.Add(question);
                            break;
                        case 6:
                            hard6.Add(question);
                            break;
                        case 7:
                            hard7.Add(question);
                            break;
                        case 8:
                            hard8.Add(question);
                            break;
                        case 9:
                            hard9.Add(question);
                            break;
                        case 10:
                            hard10.Add(question);
                            break;
                        case 11:
                            hard11.Add(question);
                            break;
                        case 12:
                            hard12.Add(question);
                            break;
                    }
                }

                */
        /*
        foreach(Question item in hard1)
        {
            Debug.LogError(item.question);
        }
        foreach (Question item in hard2)
        {
            Debug.LogError(item.question);
        }
        foreach (Question item in hard3)
        {
            Debug.LogError(item.question);
        }
        foreach (Question item in hard4)
        {
            Debug.LogError(item.question);
        }
        foreach (Question item in hard5)
        {
            Debug.LogError(item.question);
        }
        */
        NextQuestion();



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F8))
        {
            //Application.LoadLevel(0);



            Retry();
        }
        
        if (Input.GetKeyDown(KeyCode.F9))
        {
            //Application.LoadLevel(0);

            Time.timeScale = 1f;
            foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
            {
                obj.SetActive(true);
            }
            SceneManager.LoadScene("empty");
            mini_game_menu.ingame2 = true;
        }
        


    }

    public void Retry()
    {
        Time.timeScale = 1f;
        foreach (GameObject obj in MoveDontDestroyOnLoadObjects.dontDestroyObjects)
        {
            obj.SetActive(true);
        }
        //Restarts current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void NextQuestion()
    {
        VauleuWON();
        int random = 0;
        System.Random rnd = new System.Random();

        switch (CurrentPosition)
        {
            case 1:
                random = rnd.Next(hard1.Count);
                Question question = (Question)hard1[random];
                CurrentQuestion = question.question;
                CurrentAnswearA = question.answearA;
                CurrentAnswearB = question.answearB;
                CurrentAnswearC = question.answearC;
                CurrentAnswearD = question.answearD;
                CurrentAnswear = question.answear;
                break;
            case 2:
                random = rnd.Next(hard2.Count);
                Question question2 = (Question)hard2[random];
                CurrentQuestion = question2.question;
                CurrentAnswearA = question2.answearA;
                CurrentAnswearB = question2.answearB;
                CurrentAnswearC = question2.answearC;
                CurrentAnswearD = question2.answearD;
                CurrentAnswear = question2.answear;
                break;

            case 3:
                random = rnd.Next(hard3.Count);
                Question question3 = (Question)hard3[random];
                CurrentQuestion = question3.question;
                CurrentAnswearA = question3.answearA;
                CurrentAnswearB = question3.answearB;
                CurrentAnswearC = question3.answearC;
                CurrentAnswearD = question3.answearD;
                CurrentAnswear = question3.answear;
                break;

            case 4:
                random = rnd.Next(hard4.Count);
                Question question4 = (Question)hard4[random];
                CurrentQuestion = question4.question;
                CurrentAnswearA = question4.answearA;
                CurrentAnswearB = question4.answearB;
                CurrentAnswearC = question4.answearC;
                CurrentAnswearD = question4.answearD;
                CurrentAnswear = question4.answear;
                break;

            case 5:
                random = rnd.Next(hard5.Count);
                Question question5 = (Question)hard5[random];
                CurrentQuestion = question5.question;
                CurrentAnswearA = question5.answearA;
                CurrentAnswearB = question5.answearB;
                CurrentAnswearC = question5.answearC;
                CurrentAnswearD = question5.answearD;
                CurrentAnswear = question5.answear;
                break;

            case 6:
                random = rnd.Next(hard6.Count);
                Question question6 = (Question)hard6[random];
                CurrentQuestion = question6.question;
                CurrentAnswearA = question6.answearA;
                CurrentAnswearB = question6.answearB;
                CurrentAnswearC = question6.answearC;
                CurrentAnswearD = question6.answearD;
                CurrentAnswear = question6.answear;
                break;

            case 7:
                random = rnd.Next(hard7.Count);
                Question question7 = (Question)hard7[random];
                CurrentQuestion = question7.question;
                CurrentAnswearA = question7.answearA;
                CurrentAnswearB = question7.answearB;
                CurrentAnswearC = question7.answearC;
                CurrentAnswearD = question7.answearD;
                CurrentAnswear = question7.answear;
                break;

            case 8:
                random = rnd.Next(hard8.Count);
                Question question8 = (Question)hard8[random];
                CurrentQuestion = question8.question;
                CurrentAnswearA = question8.answearA;
                CurrentAnswearB = question8.answearB;
                CurrentAnswearC = question8.answearC;
                CurrentAnswearD = question8.answearD;
                CurrentAnswear = question8.answear;
                break;

            case 9:
                random = rnd.Next(hard9.Count);
                Question question9 = (Question)hard9[random];
                CurrentQuestion = question9.question;
                CurrentAnswearA = question9.answearA;
                CurrentAnswearB = question9.answearB;
                CurrentAnswearC = question9.answearC;
                CurrentAnswearD = question9.answearD;
                CurrentAnswear = question9.answear;
                break;

            case 10:
                random = rnd.Next(hard10.Count);
                Question question10 = (Question)hard10[random];
                CurrentQuestion = question10.question;
                CurrentAnswearA = question10.answearA;
                CurrentAnswearB = question10.answearB;
                CurrentAnswearC = question10.answearC;
                CurrentAnswearD = question10.answearD;
                CurrentAnswear = question10.answear;
                break;


            case 11:
                random = rnd.Next(hard11.Count);
                Question question11 = (Question)hard11[random];
                CurrentQuestion = question11.question;
                CurrentAnswearA = question11.answearA;
                CurrentAnswearB = question11.answearB;
                CurrentAnswearC = question11.answearC;
                CurrentAnswearD = question11.answearD;
                CurrentAnswear = question11.answear;
                break;

            case 12:
                random = rnd.Next(hard12.Count);
                Question question12 = (Question)hard12[random];
                CurrentQuestion = question12.question;
                CurrentAnswearA = question12.answearA;
                CurrentAnswearB = question12.answearB;
                CurrentAnswearC = question12.answearC;
                CurrentAnswearD = question12.answearD;
                CurrentAnswear = question12.answear;
                break;
        }

    }

    public static void VauleuWON()
    {

        if (CurrentPosition < 3) guaranteedWIN = 0;
        else if (CurrentPosition <= 7) guaranteedWIN = 1000;
        else if (CurrentPosition <= 12) guaranteedWIN = 50000;


        switch (CurrentPosition)
        {
            case 0:
                potentialWIN = 0;
                break;
            case 1:
                potentialWIN = 0;
                break;
            case 2:
                potentialWIN = 500;
                break;
            case 3:
                potentialWIN = 1000;
                break;
            case 4:
                potentialWIN = 2000;
                break;
            case 5:
                potentialWIN = 5000;
                break;
            case 6:
                potentialWIN = 10000;
                break;
            case 7:
                potentialWIN = 20000;
                break;
            case 8:
                potentialWIN = 50000;
                break;
            case 9:
                potentialWIN = 75000;
                break;
            case 10:
                potentialWIN = 150000;
                break;
            case 11:
                potentialWIN = 250000;
                break;
            case 12:
                potentialWIN = 500000;
                break;
        }


    }
}
