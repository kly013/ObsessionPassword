using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorOnUI : MonoBehaviour
{
    private void Start()
    {
        // ��l���p�U��ܹ���
        Cursor.visible = true;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Cursor.visible = true;
            print("1");
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Cursor.visible = false;
            print("0");
        }
    }

    public void ShowCursor()
    {
        // �I�� UI ��������ܹ���
        Cursor.visible = true;
    }

    public void HideCursor()
    {
        // ���} UI ���������ù���
        Cursor.visible = false;
    }
}
