using UnityEngine;

namespace LostInTheVillage.MiniGames.Games.Milioneirs.Scripts
{
    public class SwichMusicTrigger : MonoBehaviour
    {
        [SerializeField] private AudioClip newTrackBGM;
        [SerializeField] private AudioClip newTrackWIN;
        [SerializeField] private AudioClip newTrackLose;

        private Music music;

        private void Start()
        {
            music = FindObjectOfType<Music>();
        }

        private void Update()
        {
            if (MilioneirsQuestions.CurrentPosition >= 13)
            {
                music.ChangeBGM(newTrackWIN);
            }
            else if (QuestionController.IsLose)
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
