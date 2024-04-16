using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // ���ʳt��
    float speed = 1.5f;
    // �P�_�O�_�P����I��
    private bool isColliding = false;


    void Update()
    {
        // ���P����I���A�B���O�b��ܡA�h�i�H����
        if (!isColliding && !LevelText01.isTalking)
        {
            // ���ʿ�J
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // �p�Ⲿ�ʤ�V
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

            // �N���ʤ�V�ഫ�����⪺���a�y�Ф�V
            Vector3 localMoveDirection = transform.TransformDirection(moveDirection);

            // �ϥΥ��a�y�Ф�V�i�沾��
            transform.position += localMoveDirection * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �p�G��������A�����
        if (collision.gameObject.tag == "Wall")
        {
            isColliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // ���}����h��_����
        if (collision.gameObject.tag == "Wall")
        {
            isColliding = false;
        }
    }
    
}
