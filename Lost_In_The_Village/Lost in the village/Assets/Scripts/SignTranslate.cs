using TMPro;
using UnityEngine;

public enum StreetName
{
    DistantStreet,
    MainStreet,
    QuietStreet,
    DowntownStreet,
    GermanStreet,
    TentStreet,
    ParkStreet,
    ArchitectsStreet,
    ChineseStreet,
    VillageStreet,
    CowshedStreet,
}

public class SignTranslate : MonoBehaviour
{
    private string DistantStreetPL = "Odleg�a";
    private string MainStreetPL = "G��wna";
    private string QuietStreetPL = "Cicha";
    private string DowntownStreetPL = "�r�dmiejska";
    private string GermanStreetPL = "Niemiecka";
    private string TentStreetPL = "Namiotowa";
    private string ParkStreetPL = "Parkowa";
    private string ArchitectsStreetPL = "Architekt�w";
    private string ChineseStreetPL = "Chi�ska";
    private string VillageStreetPL = "Wiejska";
    private string CowshedStreetPL = "Obornicka";

    private string DistantStreetEN = "Distant st.";
    private string MainStreetEN = "Main st.";
    private string QuietStreetEN = "Quiet st.";
    private string DowntownStreetEN = "Downtown st.";
    private string GermanStreetEN = "German st.";
    private string TentStreetEN = "Tent st.";
    private string ParkStreetEN = "Parks st.";
    private string ArchitectsStreetEN = "Architects st.";
    private string ChineseStreetEN = "Chinese st.";
    private string VillageStreetEN = "Village st.";
    private string CowshedStreetEN = "Cowshed st.";

    private string DistantStreetGE = "Entfernte Stra�e";
    private string MainStreetGE = "Hauptstra�e";
    private string QuietStreetGE = "Ruhige Stra�e";
    private string DowntownStreetGE = "Innenstadtstra�e";
    private string GermanStreetGE = "Deutsche Stra�e";
    private string TentStreetGE = "Zeltstra�e";
    private string ParkStreetGE = "Parkstra�e";
    private string ArchitectsStreetGE = "Architektenstra�e";
    private string ChineseStreetGE = "Chinesische Stra�e";
    private string VillageStreetGE = "Dorfstra�e";
    private string CowshedStreetGE = "Kuhstallstra�e";

    private string DistantStreetSP = "Calle distante";
    private string MainStreetSP = "Calle principal";
    private string QuietStreetSP = "Calle tranquila";
    private string DowntownStreetSP = "Calle del centro";
    private string GermanStreetSP = "Calle alemana";
    private string TentStreetSP = "Tent Street";
    private string ParkStreetSP = "calle del Parque";
    private string ArchitectsStreetSP = "Calle Arquitectos";
    private string ChineseStreetSP = "Calle china";
    private string VillageStreetSP = "calle del pueblo";
    private string CowshedStreetSP = "calle establo";

    public TextMeshProUGUI street1;
    public TextMeshProUGUI street2;

    public StreetName streetname1;
    public StreetName streetname2;

    void Start()
    {
        street1.text = Select(streetname1);
        street2.text = Select(streetname2);
    }

    void Update()
    {

    }

    private string Select(StreetName street)
    {
        string text = "";
        switch (street)
        {
            case StreetName.DistantStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = DistantStreetPL;
                        break;
                    case Language_enum.English:
                        text = DistantStreetEN;
                        break;
                    case Language_enum.German:
                        text = DistantStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = DistantStreetSP;
                        break;
                }
                break;
            case StreetName.MainStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = MainStreetPL;
                        break;
                    case Language_enum.English:
                        text = MainStreetEN;
                        break;
                    case Language_enum.German:
                        text = MainStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = MainStreetSP;
                        break;
                }
                break;
            case StreetName.QuietStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = QuietStreetPL;
                        break;
                    case Language_enum.English:
                        text = QuietStreetEN;
                        break;
                    case Language_enum.German:
                        text = QuietStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = QuietStreetSP;
                        break;
                }
                break;
            case StreetName.DowntownStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = DowntownStreetPL;
                        break;
                    case Language_enum.English:
                        text = DowntownStreetEN;
                        break;
                    case Language_enum.German:
                        text = DowntownStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = DowntownStreetSP;
                        break;
                }
                break;
            case StreetName.GermanStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = GermanStreetPL;
                        break;
                    case Language_enum.English:
                        text = GermanStreetEN;
                        break;
                    case Language_enum.German:
                        text = GermanStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = GermanStreetSP;
                        break;
                }
                break;
            case StreetName.TentStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = TentStreetPL;
                        break;
                    case Language_enum.English:
                        text = TentStreetEN;
                        break;
                    case Language_enum.German:
                        text = TentStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = TentStreetSP;
                        break;
                }
                break;
            case StreetName.ParkStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = ParkStreetPL;
                        break;
                    case Language_enum.English:
                        text = ParkStreetEN;
                        break;
                    case Language_enum.German:
                        text = ParkStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = ParkStreetSP;
                        break;
                }
                break;
            case StreetName.ArchitectsStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = ArchitectsStreetPL;
                        break;
                    case Language_enum.English:
                        text = ArchitectsStreetEN;
                        break;
                    case Language_enum.German:
                        text = ArchitectsStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = ArchitectsStreetSP;
                        break;
                }
                break;
            case StreetName.ChineseStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = ChineseStreetPL;
                        break;
                    case Language_enum.English:
                        text = ChineseStreetEN;
                        break;
                    case Language_enum.German:
                        text = ChineseStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = ChineseStreetSP;
                        break;
                }
                break;
            case StreetName.VillageStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = VillageStreetPL;
                        break;
                    case Language_enum.English:
                        text = VillageStreetEN;
                        break;
                    case Language_enum.German:
                        text = VillageStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = VillageStreetSP;
                        break;
                }
                break;
            case StreetName.CowshedStreet:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        text = CowshedStreetPL;
                        break;
                    case Language_enum.English:
                        text = CowshedStreetEN;
                        break;
                    case Language_enum.German:
                        text = CowshedStreetGE;
                        break;
                    case Language_enum.Spain:
                        text = CowshedStreetSP;
                        break;
                }
                break;
        }
        return text;
    }
}
