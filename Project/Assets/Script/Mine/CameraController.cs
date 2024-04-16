using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 定義為單例實例
    public static CameraController instance;

    // 轉動靈敏度
    public float sensitivity = 3f;
    // 玩家 Transform 
    public Transform playerTra; 
    // 垂直旋轉值
    private float verticalRotation = 0f;

    void Awake()
    {
        // 確保為單例模式
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start()
    {
        // 隱藏並鎖定鼠標到屏幕中心
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (!LevelText01.isTalking)
        {
            // 滑鼠移動偏移量
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // 計算旋轉值
            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

            // 依垂直旋轉角度旋轉
            transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

            // 將玩家角色的水平旋轉角度轉換為四元數
            playerTra.Rotate(Vector3.up * mouseX);
        }
    }
}
