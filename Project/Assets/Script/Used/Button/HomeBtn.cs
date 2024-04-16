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
        // ����������
        if (!videoPlayer.isPlaying && videoPlayer.time >= videoPlayer.length)
        {
            SceneManager.LoadScene("Level01");
        }
    }

    // ��start
    public void onClickStart()
    {
        // �����䭵��
        MusicController.instance.PlaySoundEffect("clickBtn");
        // ���v��
        video.SetActive(true);
        videoPlayer.Play();
    }

    // ��Exit
    public void onClickExit()
    {
        // �����䭵��
        MusicController.instance.PlaySoundEffect("clickBtn");
        Application.Quit();
    }

    // ��skip
    public void onClickSkip()
    {
        // �����䭵��
        MusicController.instance.PlaySoundEffect("clickBtn");

        // ����������
        SceneManager.LoadScene("Level01");
    }

    // ���ܼ���t��
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
