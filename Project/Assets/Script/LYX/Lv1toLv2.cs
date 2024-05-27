using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lv1toLv2 : MonoBehaviour
{
    public VideoPlayer vp;

    // �v������t��
    int playSpeed = 1;
    // ����t�פ�r
    public Text speedText;

    public GameObject restartBtn;

    void Start()
    {

        vp.loopPointReached += EndReached;

        // ���걱��Цb������
        Cursor.lockState = CursorLockMode.None;
        // ���ХX�{
        Cursor.visible = true;
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

        vp.playbackSpeed = playSpeed;
        speedText.text = "X" + playSpeed;
    }

    public void onClickRestart()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void onClickExit()
    {
        Application.Quit();
    }

    public void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        restartBtn.SetActive(true);
    }
}
