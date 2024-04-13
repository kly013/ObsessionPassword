using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class HomeBtn : MonoBehaviour
{
    // �v��
    public GameObject video;
    // �v������
    public VideoPlayer videoPlayer;
    // �v������t��
    int playSpeed = 1;
    // ����t�פ�r
    public Text speedText;

    private void Update()
    {
        if (!videoPlayer.isPlaying && videoPlayer.time >= videoPlayer.length)
        {
            LevelController.level++;
            SceneManager.LoadScene("Level01");
        }
    }

    public void onClickStart()
    {
        MusicController.instance.PlaySoundEffect("clickBtn");
        video.SetActive(true);
        videoPlayer.Play();
    }

    public void onClickExit()
    {
        MusicController.instance.PlaySoundEffect("clickBtn");
        Application.Quit();
    }

    public void onClickSkip()
    {
        MusicController.instance.PlaySoundEffect("clickBtn");
        LevelController.level++;
        SceneManager.LoadScene("Level01");
    }

    // ���ܼ���t��
    public void onClickAcc()
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
