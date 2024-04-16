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
            
            ObjTalk.text = "看來進到狗狗的回憶裡了";
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
            ObjTalk.text = "讓我來看看資訊卡上面寫了什麼";
        }
        if (dialogueText == 2)
        {
            ObjTalk.text = "生日嗎...哼嗯...";
        }
        if (dialogueText == 3)
        {
            ObjTalk.text = "總之先在周圍到處看看吧";
        }
        if (dialogueText == 4)
        {
            ObjTalk.text = "*按住Alt出現鼠標可點選物品欄，使用道具，點兩下取消。";
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
