using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // 移動速度
    public float moveSpeed;
    // 轉頭速度
    public float rotatSpeed;

    // 計算 xy 軸旋轉
    float xRotation = 0;
    float yRotation = 0;

    void Update()
    {
        // 方向量值
        float h = -Input.GetAxis("Horizontal");
        float v = -Input.GetAxis("Vertical");

        // 將自身座標轉成世界座標，保持以自身前後左右走
        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection = new Vector3(moveDirection.x, 0, moveDirection.z);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        // 滑鼠 xy 軸量值
        float mouseX = -Input.GetAxis("Mouse X") * rotatSpeed * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * rotatSpeed * Time.deltaTime;

        // 判斷有沒有在走路
        if (h == 0 && v == 0)
        {
            // 選擇左右轉或上下看
            if (Mathf.Abs(mouseX) >= Mathf.Abs(mouseY))
            {
                yRotation -= mouseX;
            }
            else
            {
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            }

            // 轉動
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
        else
        {
            // 移動
            Vector3 roat = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }

        // 點擊東西後不動不轉
        if (LevelText01.isTalking == true)
        {
            moveSpeed = 0;
            rotatSpeed = 0;
        }
        else
        {
            moveSpeed = 1f;
            rotatSpeed= 200;
        }
    }
}
