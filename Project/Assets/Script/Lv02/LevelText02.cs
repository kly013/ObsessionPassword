using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText02 : MonoBehaviour
{
    // 判斷是否在看對話
    static public bool isTalking;
    bool isThose;  // 保持原始名稱

    // 對話框
    public GameObject DialogueBG;
    // 對話框文字
    public Text ObjTalk;
    // 空白處按鈕
    public GameObject clickSpace;

    string objtext = "";

    // notHearText 方法
    public void notHearText(string gameobjName)
    {
        isThose = true;
        GenerateObjectDescription(gameobjName);
    }

    // canHearText 方法
    public void canHearText(string gameobjName)
    {
        isThose = false;
        GenerateObjectDescription(gameobjName);
    }

    // 生成物件描述文字的方法
    private void GenerateObjectDescription(string gameobjName)
    {
        // 判斷物件類別
        string objectType = GetObjectType(gameobjName);

        switch (objectType)
        {
            case "Leaf":
                objtext = isThose ? "葉子" : "葉子";
                break;
            case "BanyanTree":
                objtext = isThose ? "榮樹" : "這個燒了會產生大量的煙，不太適合拿來當柴燒。";
                break;
            case "BanyanTreeHome":
                objtext = isThose ? "樹林中的大樹。" : "還好還有這裡可以躲雨。";
                break;
            case "CamphorTree":
                objtext = isThose ? "蟑樹" : "這個木頭有一個香香的味道。";
                break;
            case "WaxTree":
                objtext = isThose ? "目辣樹" : "我記得這樹的果實很適合當燃料。";
                break;
            case "Battery":
                objtext = isThose ? "太好了，可以幫沒電的物品更換電池了。" : "人類的東西，不知道是什麼。";
                break;
            case "Bone":
                objtext = isThose ? "骨頭" : "骨頭";
                break;
            case "Box":
                objtext = isThose ? "看起來很好吃，菌褶是白色的。" : "好吃的菇，每次抓不到小動物都會吃這個。";
                break;
            case "Branches":
                objtext = isThose ? "散落的樹枝。" : "拿來生火很好用。";
                break;
            case "Cloth":
                objtext = isThose ? "看起來是某人遺落的衣服。" : "濕衣服，蓋著更冷了。";
                break;
            case "Group":
                objtext = isThose ? "倒塌的枯樹" : "體積很大很適合躲避天敵。";
                break;
            case "Lighter":
                objtext = isThose ? "打火機點不起來。還有一點燃料可以用，要怎麼倒出來呢？" : "裡面的液體是很棒的燃料，但也很容易釀成森林大火。";
                break;
            case "Matches":
                objtext = isThose ? "是火柴，但怎麼點不起來。" : "人類的點火工具，但濕透了無法順利點燃。";
                break;
            case "FlashLight":
                objtext = isThose ? "手電筒，沒電了需要換電池。" : "每次被照到眼睛都好痛。";
                break;
            case "Pistacia":
                objtext = isThose ? "煌蓮木" : "我記得這樹的果實很適合當燃料。";
                break;
            case "RoundStone":
                objtext = isThose ? "圓圓的石頭，看著蠻可愛的。" : "別踩那些石頭，踩到很容易跌倒。";
                break;
            case "SharpStone":
                objtext = isThose ? "尖銳的石頭，一不小心碰到可能會受傷。" : "堅硬又尖的石頭適合破壞東西，兩顆互相摩擦的話好像還會產生小火花。";
                break;
            case "SmoothStone":
                objtext = isThose ? "板子般的石頭，看起來可以當架子。" : "用來隔開濕濕的地板，不管是放獵物還是稍作休息都很方便。";
                break;
            case "StoneTiger":
                objtext = isThose ? "病懨懨的石虎，看起來非常虛弱" : "是妹妹，需要快點去找保暖的東西才行";
                break;
            // 未知物件
            default:
                objtext = "不是很確定這是什麼。";
                break;
        }

        // 顯示對話框
        ShowDialogue();
    }

    // 顯示對話框的方法
    private void ShowDialogue()
    {
        if (isThose)
        {
            isTalking = true;
        }
        if (isTalking)
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = objtext;
            clickSpace.SetActive(true);
        }
    }

    // 取得物件類別
    private string GetObjectType(string objName)
    {
        int index = objName.IndexOfAny("0123456789".ToCharArray()); // 找到第一個數字的索引
        if (index != -1)
        {
            return objName.Substring(0, index);
        }
        return objName; // 如果沒有數字，返回原始名稱
    }
}

