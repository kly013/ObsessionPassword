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
            
            ObjTalk.text = "這次是到石虎媽媽的回憶裡了";
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
            ObjTalk.text = "資訊卡又寫了什麼呢";
        }
        if (dialogueText == 2)
        {
            ObjTalk.text = "石虎哥哥?是要找到她的小孩嗎?";
        }
        if (dialogueText == 3)
        {
            ObjTalk.text = "總之一樣先在周圍到處看看吧";
        }
        if (dialogueText == 4)
        {
            ObjTalk.text = "*按住Alt出現鼠標可點選物品欄，使用道具，點兩下取消。";
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
