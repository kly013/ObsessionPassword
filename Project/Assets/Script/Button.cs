using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick()
    {
        SceneManager.LoadScene("level01");
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
