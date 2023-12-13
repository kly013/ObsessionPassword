using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideControl : MonoBehaviour
{
    public VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {

        vp.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBackSpeed()
    {
        if (vp)
        {
            if (vp.playbackSpeed == 1.0f)
            {
                vp.playbackSpeed = 2.0f;
            }
            else
            {
                vp.playbackSpeed = 1.0f;
            }
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level01");
    }

    public void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Level01");
    }
    //public void EndReached2(UnityEngine.Video.VideoPlayer vp)
    //{
    //    vp.playbackSpeed = vp.playbackSpeed * 10.0F;
    //}


}
