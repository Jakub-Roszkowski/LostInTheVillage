using LostInTheVillage.Character;
using System.Collections.Generic;
using UnityEngine;

namespace LostInTheVillage.Helpers.Translations.CharacterTranslate
{
    public class CharacterTranslateDictionary
    {
        private static string[] WelcomeVillage2 = {
            "Ahh te okropne miasto. Jak widzisz pojawiły się wrogie roboty. Tylko Orzeł może nas uratować. Ostatni raz widziałem go w domu alkoholików. To jest na ulicy Cichej 4",
            "Ahh this horrible city. As you can see, hostile robots have appeared. Only the Eagle can save us. The last time I saw him was at an alcoholic's home. This is on Quiet 4 Street",
            "Ahh, diese schreckliche Stadt. Wie Sie sehen können, sind feindliche Roboter aufgetaucht. Nur der Adler kann uns retten. Das letzte Mal, dass ich ihn sah, war bei einem Alkoholiker zu Hause. Es liegt in der Ruhige-Straße 4.",
            "Ahh esta horrible ciudad. Como puede ver, han aparecido robots hostiles. Sólo el Águila puede salvarnos. La última vez que lo vi fue en la casa de un alcohólico. Esto es en la calle Tranquila 4"
        };

        private static string[] Bar1 = {
            "Witaj w moim barze! Jasne, że wiem, gdzie może być orzeł, ale najpierw musisz spróbować mojego wina.",
            "Welcome to my bar! Sure, I know where the eagle might be, but first you have to taste my wine.",
            "Willkommen in meiner Bar! Klar, ich weiß, wo der Adler sein könnte, aber zuerst musst du meinen Wein probieren.",
            "¡Bienvenido a mi bar! Claro, sé dónde podría estar el águila, pero primero tienes que probar mi vino."
        };

        private static string[] Bar2 = {
            "Mam nadzieję, że smakowało. Roszkol może wiedzieć, gdzie jest Orzeł. Mieszka on przy ulicy Parkowej 4. Wpadnij jeszcze do mnie na wyższe piętra.",
            "I hope it tasted good. Roszkol may know where the Eagle is. He lives at 4 Parks Street. Come and visit me sometimes on the upper floors.",
            "Ich hoffe, es hat gut geschmeckt. Roszkol weiß vielleicht, wo der Adler ist. Er wohnt in der Parkstraße 4. Besuchen Sie mich manchmal in den oberen Etagen.",
            "Espero que supiera bien. Roszkol puede saber dónde está el Águila. Vive en la calle Parque 4. Ven a visitarme a los pisos superiores."
        };

        private static string[] Roszkol1 = {
            "Witam serdecznie w moich skromnych progach. Szukasz Orła? Zaraz ci powiem, gdzie mieszka, ale najpierw proszę, nakarm mojego psa. Śpi gdzieś na łóżku.",
            "Welcome to my humble home. Looking for an Eagle? I'll tell you where he lives in a minute, but first, please, feed my dog. He's sleeping on a bed somewhere.",
            "Willkommen in meinem bescheidenen Zuhause. Auf der Suche nach einem Adler? Ich werde Ihnen gleich sagen, wo er wohnt, aber zuerst füttern Sie bitte meinen Hund. Er schläft irgendwo auf einem Bett.",
            "Bienvenidos a mi humilde hogar. ¿Buscas un águila? Te diré dónde vive en un minuto, pero primero, por favor, alimenta a mi perro. Está durmiendo en una cama en alguna parte."
        };

        private static string[] Roszkol2 = {
            "Dzięki wielkie za usługę. Orzeł jest przy ulicy Namiotowej 21. Powodzenia!",
            "Thanks a lot for the service. The eagle is at 21 Tent Street. Good luck!",
            "Vielen Dank für den Service. Der Adler befindet sich in der Zeltstraße 21. Viel Glück!",
            "Muchas gracias por el servicio. El águila está en Tent Street 21. ¡Buena suerte!"
        };

        private static string[] OrzelWelcome = {
            "Siema! Ale wczoraj zachlałem! Trzeba jak najszybciej wyłączyć te roboty, ale na PWR zgubiłem okulary. Chodźmy jak najszybciej ich poszukać!",
            "Hiya! I have a big hangover! We need to disable these robots as soon as possible, but I lost my glasses at PWR. Let's go look for them as soon as possible!",
            "Hallo! Ich habe einen großen Kater! Wir müssen diese Roboter so schnell wie möglich außer Gefecht setzen, aber ich habe meine Brille bei PWR verloren. Lasst uns so schnell wie möglich nach ihnen suchen!",
            "¡Hola! ¡Tengo una gran resaca! Necesitamos desactivar estos robots lo antes posible, pero perdí mis anteojos en PWR. ¡Vamos a buscarlos lo antes posible!"
        };

        private static string[] OrzelGlasses = {
            "O, dziękuję bardzo, ale na Politechnice zalało serwery. Trzeba jak najszybciej włączyć kopię zapasową. Włącznik znajduje się w tunelu przy ulicy Cichej, między pierwszym a drugim domem.",
            "Oh, thank you very much, but the servers at the University of Technology were flooded. You need to enable backup as soon as possible. The switch is in the tunnel on Quiet Street, between the first and second house.",
            "Oh, vielen Dank, aber die Server der Technischen Universität waren überlastet. Sie müssen die Sicherung so schnell wie möglich aktivieren. Der Schalter befindet sich im Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus.",
            "Oh, muchas gracias, pero los servidores de la Universidad Tecnológica se inundaron. Debe habilitar la copia de seguridad lo antes posible. El interruptor está en el túnel de la calle Tranquila, entre la primera y la segunda casa."
        };

        private static string[] OrzelTunnel = {
            "Trochę tu ciemno, chodźmy do parku.",
            "It's a little dark in here, let's go to the park.",
            "Es ist etwas dunkel hier drin, lass uns in den Park gehen.",
            "Está un poco oscuro aquí, vamos al parque."
        };

        private static string[] OrzelLaptop = {
            "Bug został naprawiony błyskawicznie. Nareszcie mogę opuścić te miasto. Odprowadź mnie do bram miasta.",
            "The bug was fixed quickly. I can finally leave this town. Walk me to the city gates.",
            "Der Fehler wurde schnell behoben. Endlich kann ich diese Stadt verlassen. Begleite mich zu den Toren der Stadt.",
            "El error se solucionó rápidamente. Finalmente puedo dejar esta ciudad. Llévame a las puertas de la ciudad."
        };

        private static string[] Village1 = {
            "Budzisz się przez hałas w twojej spokojnej wiosce. Idź do centrali i dowiedz się, co się stało.",
            "You wake up to the noise in your peaceful village. Go to headquarters and find out what happened",
            "Sie wachen mit dem Lärm in Ihrem friedlichen Dorf auf. Gehen Sie zum Zentral und finden Sie heraus, was passiert ist.",
            "Te despiertas con el ruido de tu tranquilo pueblo. Ve a la sede y averigua qué pasó."
        };

        private static string[] Village1Man = {
            "Jakiś nieodpowiedzialny programista postanowił powierzyć całą swoją pracę Chatowi GPT i puścił nieprzetestowany kod na produkcję. Teraz pojawiły się wrogie roboty. Musisz iść do miasta 'Orzeł', tam jest programista, który może nas uratować.",
            "Some irresponsible programmer decided to delegate all of their work to Chatbot GPT and released untested code into production. Now hostile robots have appeared. You must go to the town of 'Orzeł,' there is a programmer who can save us.",
            "Ein verantwortungsloser Programmierer hat beschlossen, seine gesamte Arbeit dem Chatbot GPT zu überlassen und ungetesteten Code in die Produktion zu bringen. Jetzt sind feindliche Roboter aufgetaucht. Du musst in die Stadt 'Orzeł' gehen, dort ist ein Programmierer, der uns retten kann.",
            "Un programador irresponsable decidió delegar todo su trabajo en el Chatbot GPT y lanzó código no probado a producción. Ahora han aparecido robots hostiles. Debes ir a la ciudad 'Orzeł', allí hay un programador que puede salvarnos."
        };

        private static string[] Str2WelcomeVillage2 = {
            "Cicha 4",
            "Quiet 4 Street",
            "Ruhige-Straße 4",
            "calle Tranquila 4"
        };

        private static string[] Str2Bar1 = {
            "Napij się wina ze stolika",
            "Drink some wine",
            "Trink etwas Wein",
            "Toma un poco de vino"
        };

        private static string[] Str2Bar2 = {
            "Parkowa 4",
            "4 Parks Street",
            "Parkstraße 4",
            "la calle Parque 4"
        };

        private static string[] Str2Roszkol1 = {
            "Pies na łóżku",
            "The dog on the bed",
            "Der Hund auf dem Bett",
            "El perro en la cama"
        };

        private static string[] Str2Roszkol2 = {
            "Namiotowa 21",
            "21 Tent Street",
            "Zeltstraße 21",
            "Tent Street 21"
        };

        private static string[] Str2OrzelWelcome = {
            "PWR - Niemiecka",
            "PWR - German",
            "PWR - Deutsche Straße",
            "PWR - calle alemana"
        };

        private static string[] Str2OrzelGlasses = {
            "tunel przy ulicy Cichej między pierwszym a drugim domem",
            "the tunnel on Quiet Street, between the first and second house",
            "Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus",
            "el túnel de la calle Tranquila, entre la primera y la segunda casa"
        };

        private static string[] Str2OrzelTunnel = {
            "Laptop w Parku",
            "Laptop in the Park",
            "Laptop im Park",
            "Laptop en el parque"
        };
        private static string[] Str2OrzelLaptop = {
            "Bramy miasta",
            "City gates",
            "Stadttore",
            "puertas de la ciudad"
        };

        private static string[] Str2Village1 = {
            "Centrala",
            "headquarters",
            "Zentral",
            "la sede"
        };

        private static string[] Str2Village1Man = {
            "Bramy wioski",
            "Gates of the village",
            "Tore des Dorfes",
            "Puertas del pueblo"
        };

        public static Dictionary<LanguageEnum, Dictionary<PlaceEnum, (string, string, AudioClip)>> SetTranslation(CharacterSounds sounds)
        {
            Dictionary<LanguageEnum, Dictionary<PlaceEnum, (string, string, AudioClip)>> translations = new Dictionary<LanguageEnum, Dictionary<PlaceEnum, (string, string, AudioClip)>>()
            {
                {
                    LanguageEnum.Polish, new Dictionary<PlaceEnum, (string, string, AudioClip)>()
                    {
                        { PlaceEnum.Welcome_Village2, (WelcomeVillage2[0], Str2WelcomeVillage2[0], sounds.Welcome_Village2_PL) },
                        { PlaceEnum.Bar1, (Bar1[0], Str2Bar1[0], sounds.Bar1_PL) },
                        { PlaceEnum.Bar2, (Bar2[0], Str2Bar2[0], sounds.Bar2_PL) },
                        { PlaceEnum.Roszkol1, (Roszkol1[0], Str2Roszkol1[0], sounds.Roszkol1_PL) },
                        { PlaceEnum.Roszkol2, (Roszkol2[0], Str2Roszkol2[0], sounds.Roszkol2_PL) },
                        { PlaceEnum.OrzelWelcome, (OrzelWelcome[0], Str2OrzelWelcome[0], sounds.Orzel_welcome_PL) },
                        { PlaceEnum.OrzelGlasses, (OrzelGlasses[0], Str2OrzelGlasses[0], sounds.Orzel_glasses_PL) },
                        { PlaceEnum.OrzelTunel, (OrzelTunnel[0], Str2OrzelTunnel[0], sounds.Orzel_tunel_PL) },
                        { PlaceEnum.OrzelLaptop, (OrzelLaptop[0], Str2OrzelLaptop[0], sounds.Orzel_laptop_PL) },
                        { PlaceEnum.Village1, (Village1[0], Str2Village1[0], sounds.Village1_PL) },
                        { PlaceEnum.Village1Man, (Village1Man[0], Str2Village1Man[0], sounds.Village1Man_PL) }
                    }
                },
                {
                    LanguageEnum.English, new Dictionary<PlaceEnum, (string, string, AudioClip)>()
                    {
                        { PlaceEnum.Welcome_Village2, (WelcomeVillage2[1], Str2WelcomeVillage2[1], sounds.Welcome_Village2_EN) },
                        { PlaceEnum.Bar1, (Bar1[1], Str2Bar1[1], sounds.Bar1_EN) },
                        { PlaceEnum.Bar2, (Bar2[1], Str2Bar2[1], sounds.Bar2_EN) },
                        { PlaceEnum.Roszkol1, (Roszkol1[1], Str2Roszkol1[1], sounds.Roszkol1_EN) },
                        { PlaceEnum.Roszkol2, (Roszkol2[1], Str2Roszkol2[1], sounds.Roszkol2_EN) },
                        { PlaceEnum.OrzelWelcome, (OrzelWelcome[1], Str2OrzelWelcome[1], sounds.Orzel_welcome_EN) },
                        { PlaceEnum.OrzelGlasses, (OrzelGlasses[1], Str2OrzelGlasses[1], sounds.Orzel_glasses_EN) },
                        { PlaceEnum.OrzelTunel, (OrzelTunnel[1], Str2OrzelTunnel[1], sounds.Orzel_tunel_EN) },
                        { PlaceEnum.OrzelLaptop, (OrzelLaptop[1], Str2OrzelLaptop[1], sounds.Orzel_laptop_EN) },
                        { PlaceEnum.Village1, (Village1[1], Str2Village1[1], sounds.Village1_EN) },
                        { PlaceEnum.Village1Man, (Village1Man[1], Str2Village1Man[1], sounds.Village1Man_EN) }
                    }
                },
                {
                    LanguageEnum.German, new Dictionary<PlaceEnum, (string, string, AudioClip)>()
                    {
                        { PlaceEnum.Welcome_Village2, (WelcomeVillage2[2], Str2WelcomeVillage2[2], sounds.Welcome_Village2_GE) },
                        { PlaceEnum.Bar1, (Bar1[2], Str2Bar1[2], sounds.Bar1_GE) },
                        { PlaceEnum.Bar2, (Bar2[2], Str2Bar2[2], sounds.Bar2_GE) },
                        { PlaceEnum.Roszkol1, (Roszkol1[2], Str2Roszkol1[2], sounds.Roszkol1_GE) },
                        { PlaceEnum.Roszkol2, (Roszkol2[2], Str2Roszkol2[2], sounds.Roszkol2_GE) },
                        { PlaceEnum.OrzelWelcome, (OrzelWelcome[2], Str2OrzelWelcome[2], sounds.Orzel_welcome_GE) },
                        { PlaceEnum.OrzelGlasses, (OrzelGlasses[2], Str2OrzelGlasses[2], sounds.Orzel_glasses_GE) },
                        { PlaceEnum.OrzelTunel, (OrzelTunnel[2], Str2OrzelTunnel[2], sounds.Orzel_tunel_GE) },
                        { PlaceEnum.OrzelLaptop, (OrzelLaptop[2], Str2OrzelLaptop[2], sounds.Orzel_laptop_GE) },
                        { PlaceEnum.Village1, (Village1[2], Str2Village1[2], sounds.Village1_GE) },
                        { PlaceEnum.Village1Man, (Village1Man[2], Str2Village1Man[2], sounds.Village1Man_GE) }
                    }
                },
                {
                    LanguageEnum.Spanish, new Dictionary<PlaceEnum, (string, string, AudioClip)>()
                    {
                        { PlaceEnum.Welcome_Village2, (WelcomeVillage2[3], Str2WelcomeVillage2[3], sounds.Welcome_Village2_ES) },
                        { PlaceEnum.Bar1, (Bar1[3], Str2Bar1[3], sounds.Bar1_ES) },
                        { PlaceEnum.Bar2, (Bar2[3], Str2Bar2[3], sounds.Bar2_ES) },
                        { PlaceEnum.Roszkol1, (Roszkol1[3], Str2Roszkol1[3], sounds.Roszkol1_ES) },
                        { PlaceEnum.Roszkol2, (Roszkol2[3], Str2Roszkol2[3], sounds.Roszkol2_ES) },
                        { PlaceEnum.OrzelWelcome, (OrzelWelcome[3], Str2OrzelWelcome[3], sounds.Orzel_welcome_ES) },
                        { PlaceEnum.OrzelGlasses, (OrzelGlasses[3], Str2OrzelGlasses[3], sounds.Orzel_glasses_ES) },
                        { PlaceEnum.OrzelTunel, (OrzelTunnel[3], Str2OrzelTunnel[3], sounds.Orzel_tunel_ES) },
                        { PlaceEnum.OrzelLaptop, (OrzelLaptop[3], Str2OrzelLaptop[3], sounds.Orzel_laptop_ES) },
                        { PlaceEnum.Village1, (Village1[3], Str2Village1[3], sounds.Village1_ES) },
                        { PlaceEnum.Village1Man, (Village1Man[3], Str2Village1Man[3], sounds.Village1Man_ES) }
                    }
                }
                };
            return translations;
        }
    }
}