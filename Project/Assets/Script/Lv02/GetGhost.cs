using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetGhost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ghost")
        {
            //print("isLv02Finish");
            LevelController02.isLv02Finish = true;
            SceneManager.LoadScene("Lv2Pass");
        }
    }
}
