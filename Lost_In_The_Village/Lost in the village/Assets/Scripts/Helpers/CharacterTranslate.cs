using UnityEngine;

namespace Helpers
{
	public static class CharacterTranslate
	{
		private static string str_Welcome_Village2;
		private static string str_Bar1;
		private static string str_Bar2;
		private static string str_Roszkol1;
		private static string str_Roszkol2;
		private static string str_Orzel_welcome;
		private static string str_Orzel_glasses;
		private static string str_Orzel_tunel;
		private static string str_Orzel_laptop;
		private static string str_Village1;
		private static string str_Village1Man;
		private static string str2_Welcome_Village2;
		private static string str2_Bar1;
		private static string str2_Bar2;
		private static string str2_Roszkol1;
		private static string str2_Roszkol2;
		private static string str2_Orzel_welcome;
		private static string str2_Orzel_glasses;
		private static string str2_Orzel_tunel;
		private static string str2_Orzel_laptop;
		private static string str2_Village1;
		private static string str2_Village1Man;

		private static void translateText()
		{
			(str_Welcome_Village2, str_Bar1, str_Bar2, str_Roszkol1, str_Roszkol2, str_Orzel_welcome, str_Orzel_glasses, str_Orzel_tunel, str_Orzel_laptop, str_Village1, str_Village1Man, str2_Welcome_Village2, str2_Bar1, str2_Bar2, str2_Roszkol1, str2_Roszkol2, str2_Orzel_welcome, str2_Orzel_glasses, str2_Orzel_tunel, str2_Orzel_laptop, str2_Village1, str2_Village1Man) = Helpers.CharacterTextTranlate.Translate();
		}

		public static (AudioClip, string, string) Translate(Place_enum place, CharacterSounds sounds)
		{
			AudioClip audio = null;
			string promptString = "";
			string destinationString = "";

			translateText();

			switch (place)
			{
				case Place_enum.Welcome_Village2:
					promptString = str_Welcome_Village2;
					destinationString = str2_Welcome_Village2;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Welcome_Village2_PL;
							break;
						case Language_enum.English:
							audio = sounds.Welcome_Village2_EN;
							break;
						case Language_enum.German:
							audio = sounds.Welcome_Village2_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Welcome_Village2_SPA;
							break;
					}
					break;
				case Place_enum.Bar1:
					promptString = str_Bar1;
					destinationString = str2_Bar1;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Bar1_PL;
							break;
						case Language_enum.English:
							audio = sounds.Bar1_EN;
							break;
						case Language_enum.German:
							audio = sounds.Bar1_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Bar1_SPA;
							break;
					}
					break;
				case Place_enum.Bar2:
					promptString = str_Bar2;
					destinationString = str2_Bar2;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Bar2_PL;
							break;
						case Language_enum.English:
							audio = sounds.Bar2_EN;
							break;
						case Language_enum.German:
							audio = sounds.Bar2_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Bar2_SPA;
							break;
					}
					break;
				case Place_enum.Roszkol1:
					promptString = str_Roszkol1;
					destinationString = str2_Roszkol1;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Roszkol1_PL;
							break;
						case Language_enum.English:
							audio = sounds.Roszkol1_EN;
							break;
						case Language_enum.German:
							audio = sounds.Roszkol1_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Roszkol1_SPA;
							break;
					}
					break;
				case Place_enum.Roszkol2:
					promptString = str_Roszkol2;
					destinationString = str2_Roszkol2;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Roszkol2_PL;
							break;
						case Language_enum.English:
							audio = sounds.Roszkol2_EN;
							break;
						case Language_enum.German:
							audio = sounds.Roszkol2_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Roszkol2_SPA;
							break;
					}
					break;
				case Place_enum.Orzel_welcome:
					promptString = str_Orzel_welcome;
					destinationString = str2_Orzel_welcome;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Orzel_welcome_PL;
							break;
						case Language_enum.English:
							audio = sounds.Orzel_welcome_EN;
							break;
						case Language_enum.German:
							audio = sounds.Orzel_welcome_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Orzel_welcome_SPA;
							break;
					}
					break;
				case Place_enum.Orzel_glasses:
					promptString = str_Orzel_glasses;
					destinationString = str2_Orzel_glasses;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Orzel_glasses_PL;
							break;
						case Language_enum.English:
							audio = sounds.Orzel_glasses_EN;
							break;
						case Language_enum.German:
							audio = sounds.Orzel_glasses_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Orzel_glasses_SPA;
							break;
					}
					break;
				case Place_enum.Orzel_tunel:
					promptString = str_Orzel_tunel;
					destinationString = str2_Orzel_tunel;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Orzel_tunel_PL;
							break;
						case Language_enum.English:
							audio = sounds.Orzel_tunel_EN;
							break;
						case Language_enum.German:
							audio = sounds.Orzel_tunel_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Orzel_tunel_SPA;
							break;
					}
					break;
				case Place_enum.Orzel_laptop:
					promptString = str_Orzel_laptop;
					destinationString = str2_Orzel_laptop;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Orzel_laptop_PL;
							break;
						case Language_enum.English:
							audio = sounds.Orzel_laptop_EN;
							break;
						case Language_enum.German:
							audio = sounds.Orzel_laptop_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Orzel_laptop_SPA;
							break;
					}
					break;
				case Place_enum.Village1:
					promptString = str_Village1;
					destinationString = str2_Village1;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Village1_PL;
							break;
						case Language_enum.English:
							audio = sounds.Village1_EN;
							break;
						case Language_enum.German:
							audio = sounds.Village1_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Village1_SPA;
							break;
					}
					break;
				case Place_enum.Village1Man:
					promptString = str_Village1Man;
					destinationString = str2_Village1Man;
					switch (Language.language)
					{
						case Language_enum.Polish:
							audio = sounds.Village1Man_PL;
							break;
						case Language_enum.English:
							audio = sounds.Village1Man_EN;
							break;
						case Language_enum.German:
							audio = sounds.Village1Man_GER;
							break;
						case Language_enum.Spain:
							audio = sounds.Village1Man_SPA;

							break;
					}
					break;
			}
			return (audio, promptString, destinationString);
		}
	}
}

