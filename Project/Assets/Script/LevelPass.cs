using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelController.isFinishTime == true && LevelController.isFinishPhoto == true)
        {
            SceneManager.LoadScene("Lv1ToLv2Story");
        }
    }
}
