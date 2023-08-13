public enum Language_enum
{
    Polish,
    English,
    German,
    Spain
}

namespace Helpers
{
    public static class Languages
    {
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Defoult
        public static string SetTextNotAvailable()
        {
            string text = "";

            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Niedostępne";
                    break;
                case Language_enum.English:
                    text = "Not available";
                    break;
                case Language_enum.German:
                    text = "Nicht verfügbar";
                    break;
                case Language_enum.Spain:
                    text = "No disponible)";
                    break;
            }
            return text;
        }
        public static string SetTextEagle()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Orzeł";
                    break;
                case Language_enum.English:
                    text = "Eagle";
                    break;
                case Language_enum.German:
                    text = "Adler";
                    break;
                case Language_enum.Spain:
                    text = "Águila";
                    break;
            }
            return text;
        }
        public static string SetTextFindRoszkol()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "znajdź Roszkola";
                    break;
                case Language_enum.English:
                    text = "Find Roszkol";
                    break;
                case Language_enum.German:
                    text = "Finde Roszkol";
                    break;
                case Language_enum.Spain:
                    text = "Encuentra Roszkol";
                    break;
            }
            return text;
        }
        public static string SetTextPickUp()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Podnieś (E)";
                    break;
                case Language_enum.English:
                    text = "Pick up (E)";
                    break;
                case Language_enum.German:
                    text = "Abholen (E)";
                    break;
                case Language_enum.Spain:
                    text = "Levantar (E)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //control
        public static string SetTextControlInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Sterowanie (E)";
                    break;
                case Language_enum.English:
                    text = "Control (E)";
                    break;
                case Language_enum.German:
                    text = "Kontrolle (E)";
                    break;
                case Language_enum.Spain:
                    text = "Mando (E)";
                    break;
            }
            return text;
        }

        public static string SetTextControl()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
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
                case Language_enum.English:
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
                case Language_enum.German:
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
                case Language_enum.Spain:
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
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //character
        public static string SetTextCharacterInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Rozmawiaj (E)";
                    break;
                case Language_enum.English:
                    text = "Talk (E)";
                    break;
                case Language_enum.German:
                    text = "Reden (E)";
                    break;
                case Language_enum.Spain:
                    text = "Hablar (E)";
                    break;
            }
            return text;
        }

        public static string SetTextCharacterInteract2()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Rozmowa niedostępna";
                    break;
                case Language_enum.English:
                    text = "Conversation unavailable";
                    break;
                case Language_enum.German:
                    text = "Konversation nicht verfügbar";
                    break;
                case Language_enum.Spain:
                    text = "Conversación no disponible";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Console
        public static string SetTextConsoleInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Zagraj na konsoli (E)";
                    break;
                case Language_enum.English:
                    text = "Play on gameconsole (E)";
                    break;
                case Language_enum.German:
                    text = "Spielen Sie auf der Spielekonsole. (E)";
                    break;
                case Language_enum.Spain:
                    text = "Juega en la consola de juegos. (E)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //GameMessage
        public static string SetTextGameInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Podejdź do komputera";
                    break;
                case Language_enum.English:
                    text = "Go to the computer";
                    break;
                case Language_enum.German:
                    text = "Gehen Sie zum Computer";
                    break;
                case Language_enum.Spain:
                    text = "Ir a la computadora";
                    break;
            }
            return text;
        }
        public static string SetTextGameMessage()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Roszkol postanowił zabezpieczyć wejście do swojego domu prostą grą którą uruchomisz na komputerze przy wejściu.";
                    break;
                case Language_enum.English:
                    text = "Roszkol decided to secure the entrance to his house with a simple game that you will run on the computer at the entrance.";
                    break;
                case Language_enum.German:
                    text = "Roszkol beschloss, den Eingang zu seinem Haus mit einem einfachen Spiel zu sichern, das Sie am Eingang auf dem Computer ausführen.";
                    break;
                case Language_enum.Spain:
                    text = "Roszkol decidió asegurar la entrada a su casa con un juego simple que ejecutará en la computadora en la entrada.";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //wine
        public static string SetTextOnDestroyWine()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "kelnerka";
                    break;
                case Language_enum.English:
                    text = "waitress";
                    break;
                case Language_enum.German:
                    text = "Kellnerin";
                    break;
                case Language_enum.Spain:
                    text = "camarera";
                    break;
            }
            return text;
        }
        public static string SetTextWineInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Napij się wina (E)";
                    break;
                case Language_enum.English:
                    text = "Drink some wine (E)";
                    break;
                case Language_enum.German:
                    text = "Trink etwas Wein (E)";
                    break;
                case Language_enum.Spain:
                    text = "Toma un poco de vino (E)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //door evacuation
        public static string SetTextDoorEvacuationInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Otwórz bramę (E)";
                    break;
                case Language_enum.English:
                    text = "Open the gate (E)";
                    break;
                case Language_enum.German:
                    text = "öffne das Tor (E)";
                    break;
                case Language_enum.Spain:
                    text = "abre la puerta (E)";
                    break;
            }

            return text;
        }
        public static string SetTextDoorEvacuationInteract2()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "JSOS jeszcze nie działa";
                    break;
                case Language_enum.English:
                    text = "Not available";
                    break;
                case Language_enum.German:
                    text = "Nicht verfügbar";
                    break;
                case Language_enum.Spain:
                    text = "No disponible)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Laptop
        public static string SetTextLaptopInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Uruchom (E)";
                    break;
                case Language_enum.English:
                    text = "Run (E)";
                    break;
                case Language_enum.German:
                    text = "Laufen (E)";
                    break;
                case Language_enum.Spain:
                    text = "Correr (E)";
                    break;
            }
            return text;
        }

        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Backup
        public static string SetTextBackupInteract()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Uruchom (E)";
                    break;
                case Language_enum.English:
                    text = "Run (E)";
                    break;
                case Language_enum.German:
                    text = "Laufen (E)";
                    break;
                case Language_enum.Spain:
                    text = "Correr (E)";
                    break;
            }
            return text;
        }

        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Destination Village2
        public static string SetDestinationVillage2()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Porozmawiaj z człowiekiem przed wioską";
                    break;
                case Language_enum.English:
                    text = "Talk to the man outside the village";
                    break;
                case Language_enum.German:
                    text = "Sprich mit dem Mann außerhalb des Dorfes";
                    break;
                case Language_enum.Spain:
                    text = "Habla con el hombre fuera del pueblo.";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Central Village1
        public static string SetTextCentalBuild()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Centrala";
                    break;
                case Language_enum.English:
                    text = "Headquarters";
                    break;
                case Language_enum.German:
                    text = "Zentral";
                    break;
                case Language_enum.Spain:
                    text = "la sede";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Glasses
        public static string SetTextDonut()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Dostajesz";
                    break;
                case Language_enum.English:
                    text = "You get";
                    break;
                case Language_enum.German:
                    text = "Du erhältst";
                    break;
                case Language_enum.Spain:
                    text = "Usted obtiene";
                    break;
            }
            return text;
        }

        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Game to in
        public static string SetTextGameToIn()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Zagraj (E)";
                    break;
                case Language_enum.English:
                    text = "Play (E)";
                    break;
                case Language_enum.German:
                    text = "Spielen (E)";
                    break;
                case Language_enum.Spain:
                    text = "Jugar (E)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Płotka
        public static string SetTextFeed()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Nakarm Płotke (E)";
                    break;
                case Language_enum.English:
                    text = "Feed Roach (E)";
                    break;
                case Language_enum.German:
                    text = "Füttern Plötze (E)";
                    break;
                case Language_enum.Spain:
                    text = "alimentar Sardinilla(E)";
                    break;
            }
            return text;
        }
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //Open/Close
        public static string SetTextOpenClose()
        {
            string text = "";
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
            return text;
        }

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

            switch (Language.language)
            {
                case Language_enum.Polish:
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
                case Language_enum.English:
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
                case Language_enum.German:
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
                case Language_enum.Spain:
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
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        //MiniGames
        //Defoults
        public static string SetTextExitPanel()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Aby uruchomić ponownie naciśnij klawisz F8" + "\n" +
                        "Aby zamknąć gre naciśnij F9";
                    break;
                case Language_enum.English:
                    text = "To restart, press the F8 key." + "\n" +
                        "To close the game, press F9.";
                    break;
                case Language_enum.German:
                    text = "Um neu zu starten, drücke die F8-Taste." + "\n" +
                        "Um das Spiel zu schließen, drücke die F9-Taste.";
                    break;
                case Language_enum.Spain:
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
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Drogi przyjacielu moim skromnym zdaniem poprawna odpowiedź to: ";
                    break;
                case Language_enum.English:
                    text = "Dear friend, in my humble opinion, the correct answer is: ";
                    break;
                case Language_enum.German:
                    text = "Lieber Freund, meiner bescheidenen Meinung nach ist die richtige Antwort: ";
                    break;
                case Language_enum.Spain:
                    text = "Querido amigo, en mi humilde opinión, la respuesta correcta es: ";
                    break;
            }
            return text;
        }

        public static string SetTextPublicAnswear()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "Tak odpowiedziała publiczność:";
                    break;
                case Language_enum.English:
                    text = "This is how the audience responded:";
                    break;
                case Language_enum.German:
                    text = "So hat das Publikum geantwortet:";
                    break;
                case Language_enum.Spain:
                    text = "Así respondió la audiencia:";
                    break;
            }
            return text;
        }

        public static string SetTextWin()
        {
            string text = "";
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = " Wygrałeś: ";
                    break;
                case Language_enum.English:
                    text = " You won: ";
                    break;
                case Language_enum.German:
                    text = " Du hast gewonnen: ";
                    break;
                case Language_enum.Spain:
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
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text = "wygrałeś w czasie:\n" + time + "\n" + "Naciśnij F8 aby zacząć ponownie" + "\n" + "Naciśnij F9 aby wyjść";
                    break;
                case Language_enum.English:
                    text = "you won in time:\n" + time + "\n" + "Press F8 to start again" + "\n" + "Press F9 to exit";
                    break;
                case Language_enum.German:
                    text = "Sie haben in der Zeit gewonnen:\n" + time + "\n" + "Drücken Sie F8, um erneut zu beginnen" + "\n" + "Drücken Sie F9, um zu beenden";
                    break;
                case Language_enum.Spain:
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
            switch (Language.language)
            {
                case Language_enum.Polish:
                    text1 = "Wygrałeś";
                    text2 = "Przegrałeś";
                    text3 = "Czas:";
                    text4 = "Wynik:";
                    text5 = "[Naciśnij F8 aby uruchomić ponownie]";
                    text6 = "[Naciśnij F9 aby skończyć gre]";
                    break;
                case Language_enum.English:
                    text1 = "You won!";
                    text2 = "You lost!";
                    text3 = "Time:";
                    text4 = "Score:";
                    text5 = "[Press F8 to restart]";
                    text6 = "[Press F9 to end the game]";
                    break;
                case Language_enum.German:
                    text1 = "Du hast gewonnen!";
                    text2 = "Du hast verloren!";
                    text3 = "Zeit:";
                    text4 = "Punktzahl:";
                    text5 = "[Drücken Sie F8, um neu zu starten]";
                    text6 = "[Drücken Sie F9, um das Spiel zu beenden]";
                    break;
                case Language_enum.Spain:
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
    }
}
