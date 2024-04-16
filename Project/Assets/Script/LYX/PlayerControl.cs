using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // 移動速度
    float speed = 1.5f;
    // 判斷是否與牆壁碰撞
    private bool isColliding = false;


    void Update()
    {
        // 未與牆壁碰撞，且不是在對話，則可以移動
        if (!isColliding && !LevelText01.isTalking)
        {
            // 移動輸入
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // 計算移動方向
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

            // 將移動方向轉換為角色的本地座標方向
            Vector3 localMoveDirection = transform.TransformDirection(moveDirection);

            // 使用本地座標方向進行移動
            transform.position += localMoveDirection * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 如果撞到牆壁，停止移動
        if (collision.gameObject.tag == "Wall")
        {
            isColliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // 離開牆壁則恢復移動
        if (collision.gameObject.tag == "Wall")
        {
            isColliding = false;
        }
    }
    
}
