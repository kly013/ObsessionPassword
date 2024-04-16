using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class HomeBtn : MonoBehaviour
{
    // 影片
    public GameObject video;
    // 影片播放器
    public VideoPlayer videoPlayer;
    // 影片播放速度
    int playSpeed = 1;
    // 播放速度文字
    public Text speedText;

    private void Update()
    {
        // 播完換場景
        if (!videoPlayer.isPlaying && videoPlayer.time >= videoPlayer.length)
        {
            SceneManager.LoadScene("Level01");
        }
    }

    // 按start
    public void onClickStart()
    {
        // 播按鍵音效
        MusicController.instance.PlaySoundEffect("clickBtn");
        // 播影片
        video.SetActive(true);
        videoPlayer.Play();
    }

    // 按Exit
    public void onClickExit()
    {
        // 播按鍵音效
        MusicController.instance.PlaySoundEffect("clickBtn");
        Application.Quit();
    }

    // 按skip
    public void onClickSkip()
    {
        // 播按鍵音效
        MusicController.instance.PlaySoundEffect("clickBtn");

        // 直接換場景
        SceneManager.LoadScene("Level01");
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

        videoPlayer.playbackSpeed = playSpeed;
        speedText.text = "X" + playSpeed;
    }
}
