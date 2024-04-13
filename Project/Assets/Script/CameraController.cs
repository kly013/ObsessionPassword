using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 定義為單例實例
    public static CameraController instance;

    // 鼠標靈敏度
    public float sensitivity = 2f;
    // 玩家角色的 Transform 組件
    public Transform playerTransform; 

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
        // 獲取鼠標移動的偏移量
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // 根據鼠標偏移量旋轉攝影機
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        // 將攝影機根據垂直旋轉角度旋轉
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // 將玩家角色的水平旋轉角度轉換為四元數
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
