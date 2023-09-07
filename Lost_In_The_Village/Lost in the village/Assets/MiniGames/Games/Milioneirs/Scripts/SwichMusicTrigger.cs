using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichMusicTrigger : MonoBehaviour
{

    public AudioClip newTrackBGM;
    public AudioClip newTrackWIN;
    public AudioClip newTrackLose;
    private Music theAM;
    // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<Music>();
    }

    // Update is called once per frame
    void Update()
    {
        if (test_milioneirs.CurrentPosition >= 13)
        {
            theAM.ChangeBGM(newTrackWIN);
        }
        else if (QestionText.lose)
        {
            theAM.ChangeBGM(newTrackLose);
        }
        else if (!INPUT_NICK.start)
        {
            theAM.ChangeBGM(newTrackBGM);
        }



    }

    public void OnTrigger()
    {


    }
}
