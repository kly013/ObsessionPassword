using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDia : MonoBehaviour
{
    // 資訊卡
    public GameObject infoCard;
    // 對話框
    public GameObject dia;
    // 對話框文字
    public Text diaText;

    // 對話文字內容
    string[] diaStr = { "進到狗狗回憶中了", "看看資料中寫了什麼......", "嗯...生日嗎 ? ","總之先四處看看吧 ! " };
    // 第幾個內容
    int diaNum = 0;

    private void Start()
    {
        diaText.text = diaStr[diaNum];
    }

    // 點擊對話框切換文字
    public void onClickDia()
    {
        diaNum++;
        if (diaNum < diaStr.Length)
        {
            diaText.text = diaStr[diaNum];
        }
        else
        {
            // 說完則關閉
            infoCard.SetActive(false);
            dia.SetActive(false);
            Cursor.visible = false;
            CameraController.instance.enabled = true;
        }
    }
}
