using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class SwichMusicTrigger : MonoBehaviour
    {
        [SerializeField] private AudioClip newTrackBGM;
        [SerializeField] private AudioClip newTrackWIN;
        [SerializeField] private AudioClip newTrackLose;

        private Music music;

        void Start()
        {
            music = FindObjectOfType<Music>();
        }

        void Update()
        {
            if (TestMilioneirs.CurrentPosition >= 13)
            {
                music.ChangeBGM(newTrackWIN);
            }
            else if (QestionText.lose)
            {
                music.ChangeBGM(newTrackLose);
            }
            else if (InputNick.IsStart)
            {
                music.ChangeBGM(newTrackBGM);
            }
        }
    }
}
