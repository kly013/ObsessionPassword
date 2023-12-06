using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PausePanel;
    private bool isPause;
    private bool gameisPause;
    private float timer = 0;

    // Start is called before the first frame update


    //SkillPanel=╣¤┼▓illustratedBook¬║Panel
    void Start()
    {
        
        PausePanel.gameObject.SetActive(false);


    }

    void Update()
    {
        if (!gameisPause)
        {
            CheckUser();
        }
        timer += Time.deltaTime;
        Debug.Log(timer.ToString("0"));

    }

    public void setGamePaused(bool isPaused)
    {
        gameisPause = isPaused;
    }



    public void CheckUser()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            
            if (Time.timeScale == 1)
            {
                PauseGame();
                PausePanel.gameObject.SetActive(true);
            }
            else
            {
                ResumeGame();
                PausePanel.gameObject.SetActive(false);

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
        Time.timeScale = 1;
        isPause = false;
        PausePanel.gameObject.SetActive(false);

    }
}
