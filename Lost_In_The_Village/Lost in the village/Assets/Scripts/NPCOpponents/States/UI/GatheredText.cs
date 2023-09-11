using LostInTheVillage.NPCOpponents.States.Entities;
using TMPro;
using UnityEngine;

namespace LostInTheVillage.NPCOpponents.States.UI
{
    public class GatheredText : MonoBehaviour
    {
        private TMP_Text _text;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            GetComponentInParent<Gatherer>().OnGatheredChanged += (count) => _text.SetText(count.ToString());
        }
    }
}