using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lv1toLv2 : MonoBehaviour
{
    public VideoPlayer vp;

    // 影片播放速度
    int playSpeed = 1;
    // 播放速度文字
    public Text speedText;

    public GameObject restartBtn;

    void Start()
    {

        vp.loopPointReached += EndReached;
    }

    // 改變播放速度
    public void onClickSpeed()
    {
        MusicController.instance.PlaySoundEffect("clickBtn");
        if (playSpeed < 3)
        {
            playSpeed++;
        }
        else if (playSpeed == 3)
        {
            playSpeed = 1;
        }

        vp.playbackSpeed = playSpeed;
        speedText.text = "X" + playSpeed;
    }

    public void onClickRestart()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        restartBtn.SetActive(true);
    }
}
