using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickContinue()
    {
        GameObject.Find("PauseControl").GetComponent<PauseController>().ResumeGame();
    }
    public void BackStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
        GameObject.Find("PauseControl").GetComponent<PauseController>().ResumeGame();
    }
}
