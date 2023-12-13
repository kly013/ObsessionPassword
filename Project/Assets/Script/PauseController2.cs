using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController2 : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject crossHair;
    public GameObject tools;
    private bool isPause;
    private bool gameisPause;
    private float timer = 0;

    // Start is called before the first frame update


    //SkillPanel=¹ÏÅ²illustratedBookªºPanel
    void Start()
    {
        LevelText02.isTalking = false;
        PausePanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!gameisPause)
        {
            CheckUser();
        }
        timer += Time.deltaTime;
        //Debug.Log(timer.ToString("0"));
    }

    public void setGamePaused(bool isPaused)
    {
        gameisPause = isPaused;
    }



    public void CheckUser()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (Time.timeScale == 1)
            {
                LevelText02.isTalking = true;
                PauseGame();
                PausePanel.gameObject.SetActive(true);
                crossHair.SetActive(false);
                tools.SetActive(false);
            }
            else
            {
                LevelText02.isTalking = false;
                ResumeGame();
                PausePanel.gameObject.SetActive(false);
                crossHair.SetActive(true);
                tools.SetActive(true);
            }
        }
    }

    public void OnClickContinue()
    {
        ResumeGame();
    }

    void PauseGame()
    {

        Time.timeScale = 0;
        isPause = true;
             
    }

    public void ResumeGame()
    {
        LevelText02.isTalking = false;
        Time.timeScale = 1;
        isPause = false;
        PausePanel.gameObject.SetActive(false);
        crossHair.SetActive(true);
        tools.SetActive(true);

    }

    public void BackMenu()
    {
        LevelText02.isTalking = true;
        Time.timeScale = 1;
        isPause = false;
        PausePanel.gameObject.SetActive(false);

    }
}
