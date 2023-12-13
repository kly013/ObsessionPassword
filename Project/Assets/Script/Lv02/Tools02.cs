using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools02 : MonoBehaviour
{
    public GameObject DialogueBG;
    public GameObject choseText;

    public BagController02 bagController02;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DialogueBG.SetActive(false);
            choseText.SetActive(false);
            LevelController02.isTakeLook = false;
            LevelText02.isTalking = false;
            this.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (BagController02.posNum <= 2)
            {
                DialogueBG.SetActive(false);
                choseText.SetActive(false);
                bagController02.addTools();
                LevelController02.isTakeLook = false;
                LevelText02.isTalking = false;
                this.gameObject.SetActive(false);
            }
        }
    }
}
