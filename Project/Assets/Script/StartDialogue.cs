using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialogue : MonoBehaviour
{
    public GameObject DogCard;
    public GameObject DialogueBG;
    public GameObject crossHair;
    public Text ObjTalk;
    int dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        
        dialogueText = 0;
        DialogueBG.SetActive(true);
        crossHair.SetActive(false);
        if (dialogueText == 0)
        {
            
            ObjTalk.text = "�ݨӶi�쪯�����^�и̤F";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueText==0 & dialogueText< 5)
        {
            LevelText01.isTalking = true;
        }
        //Debug.Log(LevelText01.isTalking);
        //Debug.Log(dialogueText);
    }

    public void DialogueText()
    {
        dialogueText += 1;
        if (dialogueText == 1)
        {
            DogCard.SetActive(true);
            ObjTalk.text = "���ڨӬݬݸ�T�d�W���g�F����";
        }
        if (dialogueText == 2)
        {
            ObjTalk.text = "�ͤ��...���...";
        }
        if (dialogueText == 3)
        {
            ObjTalk.text = "�`�����b�P���B�ݬݧa";
        }
        if (dialogueText == 4)
        {
            ObjTalk.text = "*����Alt�X�{���Хi�I�磌�~��A�ϥιD��A�I��U�����C";
        }
        if (dialogueText >= 5)
        {
            DogCard.SetActive(false);
            DialogueBG.SetActive(false);
            crossHair.SetActive(true);
            LevelText01.isTalking = false;
            GameObject.Find("StartDialogue").GetComponent<StartDialogue>().enabled = false;
        }

    }

}
