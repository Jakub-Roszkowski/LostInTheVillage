using UnityEngine;

namespace LostInTheVillage.Player
{
    [CreateAssetMenu(fileName = "New Player", menuName = "Player")]
    public class PlayerStats : ScriptableObject
    {
        public new string name;
        public Health health;
    }
}
