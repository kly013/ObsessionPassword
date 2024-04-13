using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ���ʳt��
    public float speed = 5f;
    // �P�_�O�_�P����I��
    private bool isColliding = false; 

    void Update()
    {
        // ���P����I���A�h���\����
        if (!isColliding)
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
        // �p�G�I��������A�h�����
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // �����}����ɡA��_����
        if (collision.gameObject.CompareTag("Wall"))
        {
            isColliding = false;
        }
    }
}
