using LostInTheVillage.SceneHelpers.SceneTranslate;

namespace LostInTheVillage.Helpers
{
    #region Enum
    public enum LanguageEnum
    {
        Polish,
        English,
        German,
        Spanish
    }
    #endregion

    public static class Languages
    {
        #region Defoult
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Defoult
        public static string SetTextNotAvailable()
        {
            string text = "";

            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Niedostępne";
                    break;
                case LanguageEnum.English:
                    text = "Not available";
                    break;
                case LanguageEnum.German:
                    text = "Nicht verfügbar";
                    break;
                case LanguageEnum.Spanish:
                    text = "No disponible)";
                    break;
            }
            return text;
        }
        public static string SetTextEagle()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Orzeł";
                    break;
                case LanguageEnum.English:
                    text = "Eagle";
                    break;
                case LanguageEnum.German:
                    text = "Adler";
                    break;
                case LanguageEnum.Spanish:
                    text = "Águila";
                    break;
            }
            return text;
        }
        public static string SetTextFindRoszkol()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "znajdź Roszkola";
                    break;
                case LanguageEnum.English:
                    text = "Find Roszkol";
                    break;
                case LanguageEnum.German:
                    text = "Finde Roszkol";
                    break;
                case LanguageEnum.Spanish:
                    text = "Encuentra Roszkol";
                    break;
            }
            return text;
        }
        public static string SetTextPickUp()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Podnieś (E)";
                    break;
                case LanguageEnum.English:
                    text = "Pick up (E)";
                    break;
                case LanguageEnum.German:
                    text = "Abholen (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Levantar (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region Control
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //control
        public static string SetTextControlInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Sterowanie (E)";
                    break;
                case LanguageEnum.English:
                    text = "Control (E)";
                    break;
                case LanguageEnum.German:
                    text = "Kontrolle (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Mando (E)";
                    break;
            }
            return text;
        }

        public static string SetTextControl()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Sterowanie:" + "\n" +
                        "WSAD - poruszanie się " + "\n" +
                        "spacja - skok" + "\n" +
                        "E - interakcja" + "\n" +
                        "Shift - sprint" + "\n" +
                        "R - przeładowanie" + "\n" +
                        "esc - pauza" + "\n" +
                        "F - latarka" + "\n" +
                        "1, 2, 3, 4 - wybór broni" + "\n" +
                        "Q - zamkniecie wiadomosci" + "\n" +
                        "";
                    break;
                case LanguageEnum.English:
                    text = "Controls:" + "\n" +
                         "WSAD - moving " + "\n" +
                         "space - jump" + "\n" +
                         "E - interaction" + "\n" +
                         "Shift - sprint" + "\n" +
                         "R - reload" + "\n" +
                         "esc - pause" + "\n" +
                         "F - flashlight" + "\n" +
                         "1, 2, 3, 4 - weapon selection" + "\n" +
                         "Q - close message" + "\n" +
                         "";
                    break;
                case LanguageEnum.German:
                    text = "Kontrolle:" + "\n“" +
                         "WSAD – Verschieben" + "\n" +
                         "Leertaste – Sprung" + "\n" +
                         "E – Interaktion" + "\n" +
                         "Shift – Sprint" + "\n“" +
                         "R – neu laden" + "\n" +
                         "esc – Pause" + "\n" +
                         "F – Taschenlampe" + "\n" +
                         "1, 2, 3, 4 – Waffenauswahl" + "\n" +
                         "Q – Nachricht schließen" + "\n" +
                         "";
                    break;
                case LanguageEnum.Spanish:
                    text = "Controles:" + "\n" +
                         "WSAD - moviendo" + "\n" +
                         "espacio - saltar" + "\n" +
                         "E - interacción" + "\n" +
                         "Shift - sprint" + "\n" +
                         "R - recargar" + "\n" +
                         "esc - pausa" + "\n" +
                         "F - linterna" + "\n" +
                         "1, 2, 3, 4 - selección de armas" + "\n" +
                         "Q - cerrar mensaje" + "\n" +
                         "";
                    break;
            }
            return text;
        }
        #endregion
        #region Character
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //character
        public static string SetTextCharacterInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Rozmawiaj (E)";
                    break;
                case LanguageEnum.English:
                    text = "Talk (E)";
                    break;
                case LanguageEnum.German:
                    text = "Reden (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Hablar (E)";
                    break;
            }
            return text;
        }

        public static string SetTextCharacterInteract2()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Rozmowa niedostępna";
                    break;
                case LanguageEnum.English:
                    text = "Conversation unavailable";
                    break;
                case LanguageEnum.German:
                    text = "Konversation nicht verfügbar";
                    break;
                case LanguageEnum.Spanish:
                    text = "Conversación no disponible";
                    break;
            }
            return text;
        }
        #endregion
        #region Console
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Console
        public static string SetTextConsoleInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Zagraj na konsoli (E)";
                    break;
                case LanguageEnum.English:
                    text = "Play on gameconsole (E)";
                    break;
                case LanguageEnum.German:
                    text = "Spielen Sie auf der Spielekonsole. (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Juega en la consola de juegos. (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region GameMessage
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //GameMessage
        public static string SetTextGameInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Podejdź do komputera";
                    break;
                case LanguageEnum.English:
                    text = "Go to the computer";
                    break;
                case LanguageEnum.German:
                    text = "Gehen Sie zum Computer";
                    break;
                case LanguageEnum.Spanish:
                    text = "Ir a la computadora";
                    break;
            }
            return text;
        }
        public static string SetTextGameMessage()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Roszkol postanowił zabezpieczyć wejście do swojego domu prostą grą którą uruchomisz na komputerze przy wejściu.";
                    break;
                case LanguageEnum.English:
                    text = "Roszkol decided to secure the entrance to his house with a simple game that you will run on the computer at the entrance.";
                    break;
                case LanguageEnum.German:
                    text = "Roszkol beschloss, den Eingang zu seinem Haus mit einem einfachen Spiel zu sichern, das Sie am Eingang auf dem Computer ausführen.";
                    break;
                case LanguageEnum.Spanish:
                    text = "Roszkol decidió asegurar la entrada a su casa con un juego simple que ejecutará en la computadora en la entrada.";
                    break;
            }
            return text;
        }
        #endregion
        #region Wine
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //wine
        public static string SetTextOnDestroyWine()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "kelnerka";
                    break;
                case LanguageEnum.English:
                    text = "waitress";
                    break;
                case LanguageEnum.German:
                    text = "Kellnerin";
                    break;
                case LanguageEnum.Spanish:
                    text = "camarera";
                    break;
            }
            return text;
        }
        public static string SetTextWineInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Napij się wina (E)";
                    break;
                case LanguageEnum.English:
                    text = "Drink some wine (E)";
                    break;
                case LanguageEnum.German:
                    text = "Trink etwas Wein (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Toma un poco de vino (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region DoorEvacuation
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //door evacuation
        public static string SetTextDoorEvacuationInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Otwórz bramę (E)";
                    break;
                case LanguageEnum.English:
                    text = "Open the gate (E)";
                    break;
                case LanguageEnum.German:
                    text = "öffne das Tor (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "abre la puerta (E)";
                    break;
            }

            return text;
        }
        public static string SetTextDoorEvacuationInteract2()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "JSOS jeszcze nie działa";
                    break;
                case LanguageEnum.English:
                    text = "Not available";
                    break;
                case LanguageEnum.German:
                    text = "Nicht verfügbar";
                    break;
                case LanguageEnum.Spanish:
                    text = "No disponible)";
                    break;
            }
            return text;
        }
        #endregion
        #region Laptop
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Laptop
        public static string SetTextLaptopInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Uruchom (E)";
                    break;
                case LanguageEnum.English:
                    text = "Run (E)";
                    break;
                case LanguageEnum.German:
                    text = "Laufen (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Correr (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region Backup
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Backup
        public static string SetTextBackupInteract()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Uruchom (E)";
                    break;
                case LanguageEnum.English:
                    text = "Run (E)";
                    break;
                case LanguageEnum.German:
                    text = "Laufen (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Correr (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region DestinationVillage2
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Destination Village2
        public static string SetDestinationVillage2()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Porozmawiaj z człowiekiem przed wioską";
                    break;
                case LanguageEnum.English:
                    text = "Talk to the man outside the village";
                    break;
                case LanguageEnum.German:
                    text = "Sprich mit dem Mann außerhalb des Dorfes";
                    break;
                case LanguageEnum.Spanish:
                    text = "Habla con el hombre fuera del pueblo.";
                    break;
            }
            return text;
        }
        #endregion
        #region CentralVillage1
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Central Village1
        public static string SetTextCentalBuild()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Centrala";
                    break;
                case LanguageEnum.English:
                    text = "Headquarters";
                    break;
                case LanguageEnum.German:
                    text = "Zentral";
                    break;
                case LanguageEnum.Spanish:
                    text = "la sede";
                    break;
            }
            return text;
        }
        #endregion
        #region Glasses
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Glasses
        public static string SetTextDonut()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Dostajesz";
                    break;
                case LanguageEnum.English:
                    text = "You get";
                    break;
                case LanguageEnum.German:
                    text = "Du erhältst";
                    break;
                case LanguageEnum.Spanish:
                    text = "Usted obtiene";
                    break;
            }
            return text;
        }
        #endregion
        #region GameToIn
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Game to in
        public static string SetTextGameToIn()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Zagraj (E)";
                    break;
                case LanguageEnum.English:
                    text = "Play (E)";
                    break;
                case LanguageEnum.German:
                    text = "Spielen (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Jugar (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region Plotka
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Płotka
        public static string SetTextFeed()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Nakarm Płotke (E)";
                    break;
                case LanguageEnum.English:
                    text = "Feed Roach (E)";
                    break;
                case LanguageEnum.German:
                    text = "Füttern Plötze (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "alimentar Sardinilla(E)";
                    break;
            }
            return text;
        }
        #endregion
        #region Open/Close
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Open/Close
        public static string SetTextOpenClose()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Otworz / Zamknij (E)";
                    break;
                case LanguageEnum.English:
                    text = "Open / Close (E)";
                    break;
                case LanguageEnum.German:
                    text = "Öffnen / Schließen (E)";
                    break;
                case LanguageEnum.Spanish:
                    text = "Abrir / Cerrar (E)";
                    break;
            }
            return text;
        }
        #endregion
        #region Menu
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Menu
        public static (string, string, string, string, string, string, string, string, string) SetTextMenu()
        {
            string Resume = "";
            string Restart = "";
            string GameLevel = "";
            string Easy = "";
            string Medium = "";
            string Hard = "";
            string Quit = "";
            string Music = "";
            string Sounds = "";

            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    Resume = "Wznów";
                    Restart = "Rozpocznij gre na nowo";
                    GameLevel = "Poziom trudności:";
                    Easy = "Łatwy";
                    Medium = "Średni";
                    Hard = "Trudny";
                    Quit = "Wyjdź z gry";
                    Music = "Wycisz muzykę";
                    Sounds = "Wycisz efekty dźwiękowe";
                    break;
                case LanguageEnum.English:
                    Resume = "Resume";
                    Restart = "Restat Game";
                    GameLevel = "Difficulty level:";
                    Easy = "Easy";
                    Medium = "Medium";
                    Hard = "Hard";
                    Quit = "Exit the game";
                    Music = "Mute music";
                    Sounds = "Mute sound effects";
                    break;
                case LanguageEnum.German:
                    Resume = "Fortsetzen";
                    Restart = "Das Spiel neu starten";
                    GameLevel = "Schwierigkeitsgrad:";
                    Easy = "Leicht";
                    Medium = "Mittel";
                    Hard = "Schwer";
                    Quit = "Spiel verlassen";
                    Music = "Musik stummschalten";
                    Sounds = "Soundeffekte stummschalten";
                    break;
                case LanguageEnum.Spanish:
                    Resume = "Continuar";
                    Restart = "Reiniciar el juego";
                    GameLevel = "Nivel de dificultad:";
                    Easy = "Fácil";
                    Medium = "Medio";
                    Hard = "Difícil";
                    Quit = "Salir del juego";
                    Music = "Silenciar la música";
                    Sounds = "Silenciar los efectos de sonido";
                    break;
            }
            return (Resume,Restart,GameLevel,Easy,Medium,Hard,Quit,Music,Sounds);
        }
        #endregion
        #region MiniGames
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //MiniGames
        //Defoults
        public static string SetTextExitPanel()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Aby uruchomić ponownie naciśnij klawisz F8" + "\n" +
                        "Aby zamknąć gre naciśnij F9";
                    break;
                case LanguageEnum.English:
                    text = "To restart, press the F8 key." + "\n" +
                        "To close the game, press F9.";
                    break;
                case LanguageEnum.German:
                    text = "Um neu zu starten, drücke die F8-Taste." + "\n" +
                        "Um das Spiel zu schließen, drücke die F9-Taste.";
                    break;
                case LanguageEnum.Spanish:
                    text = "Para reiniciar, presiona la tecla F8." + "\n" +
                        "Para cerrar el juego, presiona la tecla F9.";
                    break;
            }
            return text;
        }
        //_______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Milioneirs
        public static string SetTextFriendTelephone()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Drogi przyjacielu moim skromnym zdaniem poprawna odpowiedź to: ";
                    break;
                case LanguageEnum.English:
                    text = "Dear friend, in my humble opinion, the correct answer is: ";
                    break;
                case LanguageEnum.German:
                    text = "Lieber Freund, meiner bescheidenen Meinung nach ist die richtige Antwort: ";
                    break;
                case LanguageEnum.Spanish:
                    text = "Querido amigo, en mi humilde opinión, la respuesta correcta es: ";
                    break;
            }
            return text;
        }

        public static string SetTextPublicAnswear()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "Tak odpowiedziała publiczność:";
                    break;
                case LanguageEnum.English:
                    text = "This is how the audience responded:";
                    break;
                case LanguageEnum.German:
                    text = "So hat das Publikum geantwortet:";
                    break;
                case LanguageEnum.Spanish:
                    text = "Así respondió la audiencia:";
                    break;
            }
            return text;
        }

        public static string SetTextWin()
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = " Wygrałeś: ";
                    break;
                case LanguageEnum.English:
                    text = " You won: ";
                    break;
                case LanguageEnum.German:
                    text = " Du hast gewonnen: ";
                    break;
                case LanguageEnum.Spanish:
                    text = " ¡Has ganado! ";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Puzzle
        public static string SetTextPuzzle(string time)
        {
            string text = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text = "wygrałeś w czasie:\n" + time + "\n" + "Naciśnij F8 aby zacząć ponownie" + "\n" + "Naciśnij F9 aby wyjść";
                    break;
                case LanguageEnum.English:
                    text = "you won in time:\n" + time + "\n" + "Press F8 to start again" + "\n" + "Press F9 to exit";
                    break;
                case LanguageEnum.German:
                    text = "Sie haben in der Zeit gewonnen:\n" + time + "\n" + "Drücken Sie F8, um erneut zu beginnen" + "\n" + "Drücken Sie F9, um zu beenden";
                    break;
                case LanguageEnum.Spanish:
                    text = "ganaste a tiempo:\n" + time + "\n" + "Presiona F8 para comenzar de nuevo" + "\n" + "Presiona F9 para salir";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //SuperPlatform
        public static (string, string, string, string, string, string) SetTextSuperPlatformEnd()
        {
            string text1 = "";
            string text2 = "";
            string text3 = "";
            string text4 = "";
            string text5 = "";
            string text6 = "";
            switch (Language.LanguageName)
            {
                case LanguageEnum.Polish:
                    text1 = "Wygrałeś";
                    text2 = "Przegrałeś";
                    text3 = "Czas:";
                    text4 = "Wynik:";
                    text5 = "[Naciśnij F8 aby uruchomić ponownie]";
                    text6 = "[Naciśnij F9 aby skończyć gre]";
                    break;
                case LanguageEnum.English:
                    text1 = "You won!";
                    text2 = "You lost!";
                    text3 = "Time:";
                    text4 = "Score:";
                    text5 = "[Press F8 to restart]";
                    text6 = "[Press F9 to end the game]";
                    break;
                case LanguageEnum.German:
                    text1 = "Du hast gewonnen!";
                    text2 = "Du hast verloren!";
                    text3 = "Zeit:";
                    text4 = "Punktzahl:";
                    text5 = "[Drücken Sie F8, um neu zu starten]";
                    text6 = "[Drücken Sie F9, um das Spiel zu beenden]";
                    break;
                case LanguageEnum.Spanish:
                    text1 = "¡Ganaste!";
                    text2 = "¡Perdiste!";
                    text3 = "Tiempo:";
                    text4 = "Puntuación:";
                    text5 = "[Pulsa F8 para reiniciar]";
                    text6 = "[Pulsa F9 para terminar el juego]";
                    break;
            }
            return (text1, text2, text3, text4, text5, text6);
        }
        #endregion
    }
}
