using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 移動速度
    public float speed = 5f;
    // 判斷是否與牆壁碰撞
    private bool isColliding = false; 

    void Update()
    {
        // 未與牆壁碰撞，則允許移動
        if (!isColliding)
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
        // 如果碰撞到牆壁，則停止移動
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // 當離開牆壁時，恢復移動
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = false;
        }
    }
}
