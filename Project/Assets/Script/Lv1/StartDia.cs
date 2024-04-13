using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDia : MonoBehaviour
{
    // ��T�d
    public GameObject infoCard;
    // ��ܮ�
    public GameObject dia;
    // ��ܮؤ�r
    public Text diaText;

    // ��ܤ�r���e
    string[] diaStr = { "�i�쪯���^�Ф��F", "�ݬݸ�Ƥ��g�F����......", "��...�ͤ�� ? ","�`�����|�B�ݬݧa ! " };
    // �ĴX�Ӥ��e
    int diaNum = 0;

    private void Start()
    {
        diaText.text = diaStr[diaNum];
    }

    // �I����ܮؤ�����r
    public void onClickDia()
    {
        diaNum++;
        if (diaNum < diaStr.Length)
        {
            diaText.text = diaStr[diaNum];
        }
        else
        {
            // �����h����
            infoCard.SetActive(false);
            dia.SetActive(false);
            Cursor.visible = false;
            CameraController.instance.enabled = true;
        }
    }
}
