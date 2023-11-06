using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StartButtonClick()
    {
        SceneManager.LoadScene("level01");
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
