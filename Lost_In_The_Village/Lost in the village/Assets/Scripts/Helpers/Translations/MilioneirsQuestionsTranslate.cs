using LostInTheVillage.MiniGames.Games.Milioneirs.Scripts;
using LostInTheVillage.SceneHelpers.SceneTranslate;
using System.Collections.Generic;

namespace LostInTheVillage.Helpers.Translations
{
    public class MilioneirsQuestionsTranslate
    {
        private static List<Question> hard1 = new List<Question>();
        private static List<Question> hard2 = new List<Question>();
        private static List<Question> hard3 = new List<Question>();
        private static List<Question> hard4 = new List<Question>();
        private static List<Question> hard5 = new List<Question>();
        private static List<Question> hard6 = new List<Question>();
        private static List<Question> hard7 = new List<Question>();
        private static List<Question> hard8 = new List<Question>();
        private static List<Question> hard9 = new List<Question>();
        private static List<Question> hard10 = new List<Question>();
        private static List<Question> hard11 = new List<Question>();
        private static List<Question> hard12 = new List<Question>();

        public static (List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>, List<Question>) Translate()
        {
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:

                    hard1.Add(new Question("Jaki kraj ma najwięcej ludności na świecie?", "A. USA", "B. Chiny", "C. Stany Zjednoczone", "D. Rosja", "B"));
                    hard1.Add(new Question("Jaki ocean jest największy na świecie?", "A. Spokojny", "B. Atlantycki", "C. Indyjski", "D. Arktyczny", "A"));
                    hard1.Add(new Question("Jaki jest symbol chemiczny złota?", "A. Zn", "B. Fe", "C. Ag", "D. Au", "D"));
                    hard1.Add(new Question("Który z tych filmów został wyreżyserowany przez Stevena Spielberga ?", "A.Forrest Gump", "B.Jurassic Park", "C.Titanic", "D.Gladiator", "B"));
                    hard1.Add(new Question("Który z tych instrumentów jest strunowy?", "A.Trąbka", "B.Gitara", "C.Perkusja", "D.Flet", "B"));

                    hard2.Add(new Question("Która z tych planet jest najmniejsza w Układzie Słonecznym?", "A. Neptun", "B. Wenus", "C. Mars", "D. Merkury", "D"));
                    hard2.Add(new Question("Która rzeka jest najdłuższa na świecie?", "A. Nil", "B. Amazonka", "C. Jangcy", "D. Missisipi", "A"));
                    hard2.Add(new Question("Jaki jest symbol chemiczny tlenu?", "A. Tl", "B. O", "C. Te", "D. S", "B"));
                    hard2.Add(new Question("Który kolor nie jest obecny na fladze Niemiec?", "A. Czerwony", "B. Czarny", "C. Złoty", "D. Zielony", "D"));
                    hard2.Add(new Question("W którym kraju znajduje się Machu Picchu ?", "A.Chile", "B.Argentyna", "C.Peru", "D.Boliwia", "C"));
                    hard2.Add(new Question("W którym roku wybuchła I wojna światowa ?", "A. 1914", "B. 1916", "C. 1918", "D. 1920", "A"));
                    hard2.Add(new Question("Który z tych znaków zodiaku jest powiązany z elementem wody?", "A.Rak", "B.Lew", "C.Waga", "D.Strzelec", "A"));

                    hard3.Add(new Question("Jaka jest stolica Chin?", "A. Szanghaj", "B. Pekin", "C. Hongkong", "D. Kanton", "B"));
                    hard3.Add(new Question("Który z tych krajów nie graniczy z Niemcami?", "A. Szwajcaria", "B. Belgia", "C. Hiszpania", "D. Czechy", "C"));
                    hard3.Add(new Question("Który kraj jest największym producentem wina na świecie?", "A.Włochy", "B.Francja", "C.Hiszpania", "D.Australia", "A"));
                    hard3.Add(new Question("Jak nazywa się największy archipelag na świecie ?", "A.Karaiby", "B.Hawaje", "C.Filipiny", "D.Indonezja", "D"));
                    hard3.Add(new Question("W którym roku miała miejsce katastrofa w elektrowni atomowej w Czarnobylu ?", "A. 1984", "B. 1986", "C. 1988", "D. 1990", "B"));

                    hard4.Add(new Question("Który z następujących oceanów jest największy pod względem powierzchni? ", "A. Ocean Indyjski", "B. Ocean Atlantycki", "C. Ocean Spokojny", "D. Ocean Arktyczny", "C"));
                    hard4.Add(new Question("Który kraj jest największym producentem ropy naftowej na świecie? ", "A. Arabia Saudyjska", "B. Rosja", "C. Stany Zjednoczone", "D. Chiny", "A"));
                    hard4.Add(new Question("Jakie miasto jest stolicą Australii? ", "A. Sydney", "B. Melbourne", "C. Perth", "D. Canberra", "D"));
                    hard4.Add(new Question("Który z tych kontynentów ma najmniej mieszkańców ?", "A.Australia", "B.Europa", "C.Ameryka Północna", "D.Antarktyda", "D"));
                    hard4.Add(new Question("Który z tych języków jest napisany alfabetem cyrylicą?", "A.Rosyjski", "B.Grecki", "C.Chiński", "D.Arabski", "A"));
                    hard4.Add(new Question("W którym roku odkryto Amerykę ?", "A. 1400", "B. 1492", "C. 1520", "D. 1600", "B"));

                    hard5.Add(new Question("Które z następujących państw nie graniczy z Rosją? ", "A. Polska", "B. Korea Południowa", "C. Finlandia", "D. Estonia", "B"));
                    hard5.Add(new Question("Który z tych słynnych malarzy był Hiszpanem ?", "A.Claude Monet", "B.Vincent van Gogh", "C.Pablo Picasso", "D.Leonardo da Vinci", "C"));
                    hard5.Add(new Question("Jak nazywa się największe jezioro w Ameryce Południowej?", "A.Maracaibo", "B.Titicaca", "C.Poopo", "D.Argentino", "B"));
                    hard5.Add(new Question("Który z tych krajów jest najmniejszy pod względem powierzchni?", "A.San Marino", "B.Monako", "C.Nauru", "D.Malta", "B"));

                    hard6.Add(new Question("Która z planet w Układzie Słonecznym jest największa pod względem rozmiaru? ", "A. Wenus", "B. Neptun", "C. Jowisz", "D. Ziemia", "C"));
                    hard6.Add(new Question("Które z państw posiada największą powierzchnię na świecie? ", "A. Kanada", "B. Chiny", "C. Rosja", "D. Australia", "C"));

                    hard7.Add(new Question("W jakim kraju znajduje się najwięcej wulkanów ?", "A.Indonezja", "B.Japonia", "C.Stany Zjednoczone", "D.Włochy", "A"));
                    hard7.Add(new Question("Który z tych oceanów jest najmniejszy pod względem powierzchni ?", "A.Spokojny", "B.Atlantycki", "C.Indyjski", "D.Południowy", "D"));
                    hard7.Add(new Question("W jakim kraju znajduje się słynny zamek Neuschwanstein?", "A.Niemcy", "B.Austria", "C.Francja", "D.Włochy", "A"));

                    hard8.Add(new Question("Które z państw posiada najwięcej ludności w Europie? ", "A. Niemcy", "B. Wielka Brytania", "C. Rosja", "D. Francja", "C"));
                    hard8.Add(new Question("Ile kości ma dorosły człowiek ?", "A. 206", "B. 212", "C. 218", "D. 224", "A"));
                    hard8.Add(new Question("Która z tych planet jest najbliżej Słońca ?", "A.Wenus", "B.Mars", "C.Merkury", "D.Ziemia", "C"));

                    hard9.Add(new Question("Który z następujących kontynentów jest najmniejszy pod względem powierzchni? ", "A. Europa", "B. Ameryka Południowa", "C. Afryka", "D. Australia", "D"));
                    hard9.Add(new Question("Która z tych górskich formacji znajduje się w Afryce ?", "A.Alpy", "B.Andy", "C.Himalaje", "D.Góry Rwenzori", "D"));
                    hard9.Add(new Question("Jakie miasto jest stolicą Stanów Zjednoczonych?", "A.Nowy Jork", "B.Los Angeles", "C.Chicago", "D.Waszyngton", "D"));
                    hard9.Add(new Question("Który z tych aktorów zagrał Jamesa Bonda w największej liczbie filmów ?", "A.Sean Connery", "B.Roger Moore", "C.Pierce Brosnan", "D.Daniel Craig", "B"));

                    hard10.Add(new Question("Która z planet Układu Słonecznego ma najwięcej księżyców?", "A. Jowisz", "B. Saturn", "C. Uran", "D. Neptun", "A"));
                    hard10.Add(new Question("Jakie państwo leży na Półwyspie Apenińskim?", "A.Grecja", "B.Hiszpania", "C.Włochy", "D.Portugalia", "C"));
                    hard10.Add(new Question("Który z tych krajów nie leży w Europie?", "A.Serbia", "B.Rumunia", "C.Kazachstan", "D.Czarnogóra", "C"));

                    hard11.Add(new Question("W jakim kraju narodził się malarz Vincent van Gogh?", "A. Francja", "B. Niemcy", "C. Holandia", "D. Włochy", "C"));
                    hard11.Add(new Question("Który piosenkarz jest autorem utworu 'Thriller'?", "A. Michael Jackson", "B. Prince", "C. Elvis Presley", "D. Madonna", "A"));
                    hard11.Add(new Question("Która z tych piramid jest największa?", "A.Piramida Cheopsa", "B.Piramida Mykerinosa", "C.Piramida Chefrena", "D.Piramida Amenemhata III", "A"));

                    hard12.Add(new Question("Które państwo jest największym producentem kawy na świecie?", "A. Brazylia", "B. Kolumbia", "C. Etiopia", "D. Wietnam", "A"));
                    hard12.Add(new Question("Która z tych drużyn piłkarskich ma siedzibę w Londynie ?", "A.Arsenal", "B.Manchester United", "C.Liverpool", "D.Everton", "A"));
                    break;
                case LanguageEnum.English:

                    hard1.Add(new Question("Which country has the most population in the world?", "A. USA", "B. China", "C. United States", "D. Russia", "B"));
                    hard1.Add(new Question("What is the largest ocean in the world?", "A. Pacific", "B. Atlantic", "C. Indian", "D. Arctic", "A"));
                    hard1.Add(new Question("What is the chemical symbol of gold?", "A.Zn", "B.Fe", "C.Ag", "D.Au", "D"));
                    hard1.Add(new Question("Which of these movies was directed by Steven Spielberg?", "A.Forrest Gump", "B.Jurassic Park", "C.Titanic", "D.Gladiator", "B"));
                    hard1.Add(new Question("Which of these instruments is stringed?", "A.Trumpet", "B.Guitar", "C.Drums", "D.Flet", "B"));

                    hard2.Add(new Question("Which of these planets is the smallest in the solar system?", "A. Neptune", "B. Venus", "C. Mars", "D. Mercury", "D"));
                    hard2.Add(new Question("Which is the longest river in the world?", "A. Nile", "B. Amazon", "C. Yangtze", "D. Mississippi", "A"));
                    hard2.Add(new Question("What is the chemical symbol of oxygen?", "A.Tl", "B.O", "C.Te", "D.S", "B"));
                    hard2.Add(new Question("Which color is not present on the German flag?", "A. Red", "B. Black", "C. Gold", "D. Green", "D"));
                    hard2.Add(new Question("In which country is Machu Picchu?", "A.Chile", "B.Argentina", "C.Peru", "D.Bolivia", "C"));
                    hard2.Add(new Question("What year did World War I start?", "A. 1914", "B. 1916", "C. 1918", "D. 1920", "A"));
                    hard2.Add(new Question("Which of these zodiac signs is associated with the water element?", "A.Cancer", "B.Leo", "C.Libra", "D.Sagittarius", "A"));

                    hard3.Add(new Question("What is the capital of China?", "A. Shanghai", "B. Beijing", "C. Hong Kong", "D. Guangzhou", "B"));
                    hard3.Add(new Question("Which of these countries does not border Germany?", "A. Switzerland", "B. Belgium", "C. Spain", "D. Czech Republic", "C"));
                    hard3.Add(new Question("Which country is the largest wine producer in the world?", "A.Italy", "B.France", "C.Spain", "D.Australia", "A"));
                    hard3.Add(new Question("What is the name of the largest archipelago in the world?", "A.Caribbean", "B.Hawaii", "C.Philippines", "D.Indonesia", "D"));
                    hard3.Add(new Question("In which year did the Chernobyl disaster occur?", "A. 1984", "B. 1986", "C. 1988", "D. 1990", "B"));

                    hard4.Add(new Question("Which of the following oceans is the largest by area? ", "A. Indian Ocean", "B. Atlantic Ocean", "C. Pacific Ocean", "D. Arctic Ocean", "C"));
                    hard4.Add(new Question("Which country is the largest oil producer in the world?", "A. Saudi Arabia", "B. Russia", "C. United States", "D. China", "A"));
                    hard4.Add(new Question("What city is the capital of Australia?", "A. Sydney", "B. Melbourne", "C. Perth", "D. Canberra", "D"));
                    hard4.Add(new Question("Which of these continents has the least inhabitants?", "A.Australia", "B.Europa", "C.North America", "D.Antarctica", "D"));
                    hard4.Add(new Question("Which of these languages is Cyrillic?", "A.Russian", "B.Greek", "C.Chinese", "D.Arabic", "A"));
                    hard4.Add(new Question("What year was America discovered?", "A. 1400", "B. 1492", "C. 1520", "D. 1600", "B"));

                    hard5.Add(new Question("Which of the following countries does not border Russia?", "A. Poland", "B. South Korea", "C. Finland", "D. Estonia", "B"));
                    hard5.Add(new Question("Which of these famous painters was Spanish?", "A.Claude Monet", "B.Vincent van Gogh", "C.Pablo Picasso", "D.Leonardo da Vinci", "C"));
                    hard5.Add(new Question("What is the name of the largest lake in South America?", "A.Maracaibo", "B.Titicaca", "C.Poopo", "D.Argentino", "B"));
                    hard5.Add(new Question("Which of these countries is the smallest in terms of area?", "A.San Marino", "B.Monaco", "C.Nauru", "D.Malta", "B"));

                    hard6.Add(new Question("Which planet in the solar system is the largest in terms of size? ", "A. Venus", "B. Neptune", "C. Jupiter", "D. Earth", "C"));
                    hard6.Add(new Question("Which country has the largest area in the world?", "A. Canada", "B. China", "C. Russia", "D. Australia", "C"));

                    hard7.Add(new Question("Which country has the most volcanoes?", "A.Indonesia", "B.Japan", "C.United States", "D.Italy", "A"));
                    hard7.Add(new Question("Which of these oceans is the smallest by area?", "A.Pacific", "B.Atlantic", "C.Indian", "D.South", "D"));
                    hard7.Add(new Question("In which country is the famous Neuschwanstein Castle located?", "A.Germany", "B.Austria", "C.France", "D.Italy", "A"));

                    hard8.Add(new Question("Which country has the most population in Europe?", "A. Germany", "B. Great Britain", "C. Russia", "D. France", "C"));
                    hard8.Add(new Question("How many bones does an adult human have?", "A. 206", "B. 212", "C. 218", "D. 224", "A"));
                    hard8.Add(new Question("Which of these planets is closest to the Sun?", "A.Venus", "B.Mars", "C.Mercury", "D.Earth", "C"));

                    hard9.Add(new Question("Which of the following continents is the smallest by area?", "A. Europe", "B. South America", "C. Africa", "D. Australia", "D"));
                    hard9.Add(new Question("Which of these mountain formations is in Africa?", "A.Alps", "B.Andes", "C.Himalaya", "D.Rwenzori Mountains", "D"));
                    hard9.Add(new Question("What city is the capital of the United States?", "A.New York", "B.Los Angeles", "C.Chicago", "D.Washington", "D"));
                    hard9.Add(new Question("Which of these actors played James Bond in the most movies?", "A.Sean Connery", "B.Roger Moore", "C.Pierce Brosnan", "D.Daniel Craig", "B"));

                    hard10.Add(new Question("Which solar system planet has the most moons?", "A. Jupiter", "B. Saturn", "C. Uranus", "D. Neptune", "A"));
                    hard10.Add(new Question("What country is on the Apennine Peninsula?", "A.Greece", "B.Spain", "C.Italy", "D.Portugal", "C"));
                    hard10.Add(new Question("Which of these countries is not in Europe?", "A.Serbia", "B.Romania", "C.Kazakhstan", "D.Montenegro", "C"));

                    hard11.Add(new Question("Which country was the painter Vincent van Gogh born in?", "A. France", "B. Germany", "C. Holland", "D. Italy", "C"));
                    hard11.Add(new Question("Which singer wrote 'Thriller'?", "A. Michael Jackson", "B. Prince", "C. Elvis Presley", "D. Madonna", "A"));
                    hard11.Add(new Question("Which of these pyramids is the largest?", "A. Pyramid of Cheops", "B. Pyramid of Mykerinos", "C. Pyramid of Chephren", "D. Pyramid of Amenemhat III", "A"));

                    hard12.Add(new Question("Which country is the largest coffee producer in the world?", "A. Brazil", "B. Colombia", "C. Ethiopia", "D. Vietnam", "A"));
                    hard12.Add(new Question("Which of these soccer teams are based in London?", "A.Arsenal", "B.Manchester United", "C.Liverpool", "D.Everton", "A"));
                    break;
                case LanguageEnum.German:

                    hard1.Add(new Question("Welches Land hat die größte Bevölkerung der Welt?", "A. USA", "B. China", "C. Vereinigte Staaten", "D. Russland", "B"));
                    hard1.Add(new Question("Was ist der größte Ozean der Welt?", "A. Pazifik", "B. Atlantik", "C. Indien", "D. Arktis", "A"));
                    hard1.Add(new Question("Was ist das chemische Symbol von Gold?", "A.Zn", "B.Fe", "C.Ag", "D.Au", "D"));
                    hard1.Add(new Question("Welcher dieser Filme wurde von Steven Spielberg gedreht?", "A.Forrest Gump", "B.Jurassic Park", "C.Titanic", "D.Gladiator", "B"));
                    hard1.Add(new Question("Welches dieser Instrumente ist ein Streichinstrument?", "A.Trumpet", "B.Guitar", "C.Drums", "D.Flet", "B"));

                    hard2.Add(new Question("Welcher dieser Planeten ist der kleinste im Sonnensystem?", "A. Neptun", "B. Venus", "C. Mars", "D. Merkur", "D"));
                    hard2.Add(new Question("Welcher ist der längste Fluss der Welt?", "A. Nil", "B. Amazonas", "C. Jangtse", "D. Mississippi", "A"));
                    hard2.Add(new Question("Was ist das chemische Symbol von Sauerstoff?", "A.Tl", "B.O", "C.Te", "D.S", "B"));
                    hard2.Add(new Question("Welche Farbe ist auf der deutschen Flagge nicht vorhanden?", "A. Rot", "B. Schwarz", "C. Gold", "D. Grün", "D"));
                    hard2.Add(new Question("In welchem ​​Land liegt Machu Picchu?", "A.Chile", "B.Argentina", "C.Peru", "D.Bolivien", "C"));
                    hard2.Add(new Question("In welchem ​​Jahr begann der Erste Weltkrieg?", "A. 1914", "B. 1916", "C. 1918", "D. 1920", "A"));
                    hard2.Add(new Question("Welches dieser Sternzeichen ist mit dem Wasserelement verbunden?", "A.Krebs", "B.Löwe", "C.Waage", "D.Schütze", "A"));

                    hard3.Add(new Question("Was ist die Hauptstadt von China?", "A. Shanghai", "B. Peking", "C. Hongkong", "D. Guangzhou", "B"));
                    hard3.Add(new Question("Welches dieser Länder grenzt nicht an Deutschland?", "A. Schweiz", "B. Belgien", "C. Spanien", "D. Tschechische Republik", "C"));
                    hard3.Add(new Question("Welches Land ist der größte Weinproduzent der Welt?", "A.Italien", "B.Frankreich", "C.Spanien", "D.Australien", "A"));
                    hard3.Add(new Question("Wie heißt der größte Archipel der Welt?", "A.Karibik", "B.Hawaii", "C.Philippinen", "D.Indonesien", "D"));
                    hard3.Add(new Question("In welchem ​​Jahr ereignete sich die Katastrophe von Tschernobyl?", "A. 1984", "B. 1986", "C. 1988", "D. 1990", "B"));

                    hard4.Add(new Question("Welcher der folgenden Ozeane ist flächenmäßig der größte? ", "A. Indischer Ozean", "B. Atlantischer Ozean", "C. Pazifischer Ozean", "D. Arktischer Ozean", "C"));
                    hard4.Add(new Question("Welches Land ist der größte Ölproduzent der Welt?", "A. Saudi-Arabien", "B. Russland", "C. Vereinigte Staaten", "D. China", "A"));
                    hard4.Add(new Question("Welche Stadt ist die Hauptstadt Australiens?", "A. Sydney", "B. Melbourne", "C. Perth", "D. Canberra", "D"));
                    hard4.Add(new Question("Welcher dieser Kontinente hat die wenigsten Einwohner?", "A.Australien", "B.Europa", "C.Nordamerika", "D.Antarctica", "D"));
                    hard4.Add(new Question("Welche dieser Sprachen ist Kyrillisch?", "A.Russisch", "B.Griechisch", "C.Chinesisch", "D.Arabisch", "A"));
                    hard4.Add(new Question("In welchem ​​Jahr wurde Amerika entdeckt?", "A. 1400", "B. 1492", "C. 1520", "D. 1600", "B"));

                    hard5.Add(new Question("Welches der folgenden Länder grenzt nicht an Russland?", "A. Polen", "B. Südkorea", "C. Finnland", "D. Estland", "B"));
                    hard5.Add(new Question("Welcher dieser berühmten Maler war Spanier?", "A.Claude Monet", "B.Vincent van Gogh", "C.Pablo Picasso", "D.Leonardo da Vinci", "C"));
                    hard5.Add(new Question("Wie heißt der größte See Südamerikas?", "A.Maracaibo", "B.Titicaca", "C.Poopo", "D.Argentino", "B"));
                    hard5.Add(new Question("Welches dieser Länder ist flächenmäßig das kleinste?", "A.San Marino", "B.Monaco", "C.Nauru", "D.Malta", "B"));

                    hard6.Add(new Question("Welcher Planet im Sonnensystem ist flächenmäßig der größte? ", "A. Venus", "B. Neptun", "C. Jupiter", "D. Erde", "C"));
                    hard6.Add(new Question("Welches Land hat die größte Fläche der Welt?", "A. Kanada", "B. China", "C. Russland", "D. Australien", "C"));

                    hard7.Add(new Question("Welches Land hat die meisten Vulkane?", "A.Indonesien", "B.Japan", "C.USA", "D.Italien", "A"));
                    hard7.Add(new Question("Welcher dieser Ozeane ist flächenmäßig der kleinste?", "A.Pacific", "B.Atlantic", "C.Indian", "D.South", "D"));
                    hard7.Add(new Question("In welchem ​​Land befindet sich das berühmte Schloss Neuschwanstein?", "A.Deutschland", "B.Österreich", "C.Frankreich", "D.Italien", "A"));

                    hard8.Add(new Question("Welches Land hat die größte Bevölkerung in Europa?", "A. Deutschland", "B. Großbritannien", "C. Russland", "D. Frankreich", "C"));
                    hard8.Add(new Question("Wie viele Knochen hat ein erwachsener Mensch?", "A. 206", "B. 212", "C. 218", "D. 224", "A"));
                    hard8.Add(new Question("Welcher dieser Planeten ist der Sonne am nächsten?", "A.Venus", "B.Mars", "C.Merkur", "D.Erde", "C"));

                    hard9.Add(new Question("Welcher der folgenden Kontinente ist flächenmäßig der kleinste?", "A. Europa", "B. Südamerika", "C. Afrika", "D. Australien", "D"));
                    hard9.Add(new Question("Welche dieser Bergformationen liegt in Afrika?", "A.Alpen", "B.Andes", "C.Himalaya", "D.Rwenzori-Gebirge", "D"));
                    hard9.Add(new Question("Welche Stadt ist die Hauptstadt der Vereinigten Staaten?", "A.New York", "B.Los Angeles", "C.Chicago", "D.Washington", "D"));
                    hard9.Add(new Question("Welcher dieser Schauspieler spielte James Bond in den meisten Filmen?", "A.Sean Connery", "B.Roger Moore", "C.Pierce Brosnan", "D.Daniel Craig", "B"));

                    hard10.Add(new Question("Welcher Planet des Sonnensystems hat die meisten Monde?", "A. Jupiter", "B. Saturn", "C. Uranus", "D. Neptun", "A"));
                    hard10.Add(new Question("Welches Land liegt auf der Apenninenhalbinsel?", "A.Griechenland", "B.Spanien", "C.Italien", "D.Portugal", "C"));
                    hard10.Add(new Question("Welches dieser Länder liegt nicht in Europa?", "A.Serbien", "B.Rumänien", "C.Kasachstan", "D.Montenegro", "C"));

                    hard11.Add(new Question("In welchem ​​Land wurde der Maler Vincent van Gogh geboren?", "A. Frankreich", "B. Deutschland", "C. Holland", "D. Italien", "C"));
                    hard11.Add(new Question("Welcher Sänger hat 'Thriller' geschrieben?", "A. Michael Jackson", "B. Prince", "C. Elvis Presley", "D. Madonna", "A"));
                    hard11.Add(new Question("Welche dieser Pyramiden ist die größte?", "A. Pyramide des Cheops", "B. Pyramide des Mykerinos", "C. Pyramide des Chephren", "D. Pyramide von Amenemhat III", "A"));

                    hard12.Add(new Question("Welches Land ist der größte Kaffeeproduzent der Welt?", "A. Brasilien", "B. Kolumbien", "C. Äthiopien", "D. Vietnam", "A"));
                    hard12.Add(new Question("Welche dieser Fußballmannschaften haben ihren Sitz in London?", "A.Arsenal", "B.Manchester United", "C.Liverpool", "D.Everton", "A"));

                    break;
                case LanguageEnum.Spanish:

                    hard1.Add(new Question("¿Qué país tiene la mayor población del mundo?", "A. EE. UU.", "B. China", "C. Estados Unidos", "D. Rusia", "B"));
                    hard1.Add(new Question("¿Cuál es el océano más grande del mundo?", "A. Pacífico", "B. Atlántico", "C. Índico", "D. Ártico", "A"));
                    hard1.Add(new Question("¿Cuál es el símbolo químico del oro?", "A.Zn", "B.Fe", "C.Ag", "D.Au", "D"));
                    hard1.Add(new Question("¿Cuál de estas películas fue dirigida por Steven Spielberg?", "A.Forrest Gump", "B.Jurassic Park", "C.Titanic", "D.Gladiator", "B"));
                    hard1.Add(new Question("¿Cuál de estos instrumentos es de cuerda?", "A.Trumpet", "B.Guitar", "C.Drums", "D.Flet", "B"));

                    hard2.Add(new Question("¿Cuál de estos planetas es el más pequeño del sistema solar?", "A. Neptuno", "B. Venus", "C. Marte", "D. Mercurio", "D"));
                    hard2.Add(new Question("¿Cuál es el río más largo del mundo?", "A. Nilo", "B. Amazonas", "C. Yangtze", "D. Mississippi", "A"));
                    hard2.Add(new Question("¿Cuál es el símbolo químico del oxígeno?", "A.Tl", "B.O", "C.Te", "D.S", "B"));
                    hard2.Add(new Question("¿Qué color no está presente en la bandera alemana?", "A. Rojo", "B. Negro", "C. Dorado", "D. Verde", "D"));
                    hard2.Add(new Question("¿En qué país se encuentra Machu Picchu?", "A.Chile", "B.Argentina", "C.Perú", "D.Bolivia", "C"));
                    hard2.Add(new Question("¿En qué año comenzó la Primera Guerra Mundial?", "A. 1914", "B. 1916", "C. 1918", "D. 1920", "A"));
                    hard2.Add(new Question("¿Cuál de estos signos zodiacales está asociado con el elemento agua?", "A.Cancer", "B.Leo", "C.Libra", "D.Sagittarius", "A"));

                    hard3.Add(new Question("¿Cuál es la capital de China?", "A. Shanghai", "B. Beijing", "C. Hong Kong", "D. Guangzhou", "B"));
                    hard3.Add(new Question("¿Cuál de estos países no limita con Alemania?", "A. Suiza", "B. Bélgica", "C. España", "D. República Checa", "C"));
                    hard3.Add(new Question("¿Qué país es el mayor productor de vino del mundo?", "A.Italia", "B.Francia", "C.España", "D.Australia", "A"));
                    hard3.Add(new Question("¿Cuál es el nombre del archipiélago más grande del mundo?", "A.Caribe", "B.Hawaii", "C.Filipinas", "D.Indonesia", "D"));
                    hard3.Add(new Question("¿En qué año ocurrió el desastre de Chernóbil?", "A. 1984", "B. 1986", "C. 1988", "D. 1990", "B"));

                    hard4.Add(new Question("¿Cuál de los siguientes océanos es el más grande por área?", "A. Océano Índico", "B. Océano Atlántico", "C. Océano Pacífico", "D. Océano Ártico", "C"));
                    hard4.Add(new Question("¿Qué país es el mayor productor de petróleo del mundo?", "A. Arabia Saudita", "B. Rusia", "C. Estados Unidos", "D. China", "A"));
                    hard4.Add(new Question("¿Qué ciudad es la capital de Australia?", "A. Sydney", "B. Melbourne", "C. Perth", "D. Canberra", "D"));
                    hard4.Add(new Question("¿Cuál de estos continentes tiene menos habitantes?", "A.Australia", "B.Europa", "C.Norteamérica", "D.Antártida", "D"));
                    hard4.Add(new Question("¿Cuál de estos idiomas es cirílico?", "A.Ruso", "B.Griego", "C.Chino", "D.Árabe", "A"));
                    hard4.Add(new Question("¿En qué año se descubrió América?", "A. 1400", "B. 1492", "C. 1520", "D. 1600", "B"));

                    hard5.Add(new Question("¿Cuál de los siguientes países no limita con Rusia?", "A. Polonia", "B. Corea del Sur", "C. Finlandia", "D. Estonia", "B"));
                    hard5.Add(new Question("¿Cuál de estos famosos pintores era español?", "A.Claude Monet", "B.Vincent van Gogh", "C.Pablo Picasso", "D.Leonardo da Vinci", "C"));
                    hard5.Add(new Question("¿Cómo se llama el lago más grande de Sudamérica?", "A.Maracaibo", "B.Titicaca", "C.Poopo", "D.Argentino", "B"));
                    hard5.Add(new Question("¿Cuál de estos países es el más pequeño en términos de área?", "A.San Marino", "B.Monaco", "C.Nauru", "D.Malta", "B"));

                    hard6.Add(new Question("¿Cuál de los planetas del sistema solar es el más grande en términos de tamaño? ", "A. Venus", "B. Neptuno", "C. Júpiter", "D. Tierra", "C"));
                    hard6.Add(new Question("¿Qué país tiene la mayor superficie del mundo?", "A. Canadá", "B. China", "C. Rusia", "D. Australia", "C"));

                    hard7.Add(new Question("¿Qué país tiene más volcanes?", "A.Indonesia", "B.Japón", "C.Estados Unidos", "D.Italia", "A"));
                    hard7.Add(new Question("¿Cuál de estos océanos es el más pequeño por área?", "A.Pacífico", "B.Atlántico", "C.Índico", "D.Sur", "D"));
                    hard7.Add(new Question("¿En qué país se encuentra el famoso Castillo de Neuschwanstein?", "A.Alemania", "B.Austria", "C.Francia", "D.Italia", "A"));

                    hard8.Add(new Question("¿Qué país tiene más población en Europa?", "A. Alemania", "B. Gran Bretaña", "C. Rusia", "D. Francia", "C"));
                    hard8.Add(new Question("¿Cuántos huesos tiene un humano adulto?", "A. 206", "B. 212", "C. 218", "D. 224", "A"));
                    hard8.Add(new Question("¿Cuál de estos planetas está más cerca del Sol?", "A.Venus", "B.Mars", "C.Mercury", "D.Earth", "C"));

                    hard9.Add(new Question("¿Cuál de los siguientes continentes es el más pequeño por área?", "A. Europa", "B. Sudamérica", "C. África", "D. Australia", "D"));
                    hard9.Add(new Question("¿Cuál de estas formaciones montañosas se encuentra en África?", "A.Alps", "B.Andes", "C.Himalaya", "D.Rwenzori Mountains", "D"));
                    hard9.Add(new Question("¿Qué ciudad es la capital de los Estados Unidos?", "A.Nueva York", "B.Los Ángeles", "C.Chicago", "D.Washington", "D"));
                    hard9.Add(new Question("¿Cuál de estos actores interpretó a James Bond en la mayoría de las películas?", "A.Sean Connery", "B.Roger Moore", "C.Pierce Brosnan", "D.Daniel Craig", "B"));

                    hard10.Add(new Question("¿Qué planeta del sistema solar tiene más lunas?", "A. Júpiter", "B. Saturno", "C. Urano", "D. Neptuno", "A"));
                    hard10.Add(new Question("¿Qué país se encuentra en la península de los Apeninos?", "A.Grecia", "B.España", "C.Italia", "D.Portugal", "C"));
                    hard10.Add(new Question("¿Cuál de estos países no está en Europa?", "A.Serbia", "B.Romania", "C.Kazakhstan", "D.Montenegro", "C"));

                    hard11.Add(new Question("¿En qué país nació el pintor Vincent van Gogh?", "A. Francia", "B. Alemania", "C. Holanda", "D. Italia", "C"));
                    hard11.Add(new Question("¿Qué cantante escribió 'Thriller'?", "A. Michael Jackson", "B. Prince", "C. Elvis Presley", "D. Madonna", "A"));
                    hard11.Add(new Question("¿Cuál de estas pirámides es la más grande?", "A. Pirámide de Keops", "B. Pirámide de Mykerinos", "C. Pirámide de Chephren", "D. Pirámide de Amenemhat III", "A"));

                    hard12.Add(new Question("¿Qué país es el mayor productor de café del mundo?", "A. Brasil", "B. Colombia", "C. Etiopía", "D. Vietnam", "A"));
                    hard12.Add(new Question("¿Cuál de estos equipos de fútbol tiene su sede en Londres?", "A.Arsenal", "B.Manchester United", "C.Liverpool", "D.Everton", "A"));

                    break;
            }
            return (hard1, hard2, hard3, hard4, hard5, hard6, hard7, hard8, hard9, hard10, hard11, hard12);
        }
    }
}
