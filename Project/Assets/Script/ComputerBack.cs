using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerBack : MonoBehaviour
{
    public GameObject screen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            screen.SetActive(false);
            LevelController.isClickComputer = false;
            GetComponent<ComputerBack>().enabled = false;
            LevelText01.isTalking = false;
        }
    }
}
