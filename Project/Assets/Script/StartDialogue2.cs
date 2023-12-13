using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialogue2 : MonoBehaviour
{
    public GameObject motherCard;
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
            
            ObjTalk.text = "�o���O��۪�������^�и̤F";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueText==0 & dialogueText< 5)
        {
            LevelText02.isTalking = true;
        }
        Debug.Log(LevelText02.isTalking);
        Debug.Log(dialogueText);
    }

    public void DialogueText()
    {
        dialogueText += 1;
        if (dialogueText == 1)
        {
            motherCard.SetActive(true);
            ObjTalk.text = "��T�d�S�g�F����O";
        }
        if (dialogueText == 2)
        {
            ObjTalk.text = "�۪����?�O�n���o���p�Ķ�?";
        }
        if (dialogueText == 3)
        {
            ObjTalk.text = "�`���@�˥��b�P���B�ݬݧa";
        }
        if (dialogueText == 4)
        {
            ObjTalk.text = "*����Alt�X�{���Хi�I�磌�~��A�ϥιD��A�I��U�����C";
        }
        if (dialogueText >= 5)
        {
            motherCard.SetActive(false);
            DialogueBG.SetActive(false);
            crossHair.SetActive(true);
            LevelText02.isTalking = false;
            GameObject.Find("StartDialogue").GetComponent<StartDialogue2>().enabled = false;
        }

    }

}
