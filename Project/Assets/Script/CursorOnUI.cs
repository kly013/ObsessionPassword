using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorOnUI : MonoBehaviour
{
    private void Start()
    {
        // 初始情況下顯示鼠標
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
        // 點擊 UI 元素時顯示鼠標
        Cursor.visible = true;
    }

    public void HideCursor()
    {
        // 離開 UI 元素時隱藏鼠標
        Cursor.visible = false;
    }
}
