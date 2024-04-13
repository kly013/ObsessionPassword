using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // ���ʳt��
    private bool isColliding = false; // �P�_�O�_�P����I��

    void Update()
    {
        // �p�G���P����I���A�h���\����
        if (!isColliding)
        {
            // ������a��J
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // �p�Ⲿ�ʤ�V
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

            // �N���ʤ�V�ഫ�����⪺���a�Ŷ���V
            Vector3 localMoveDirection = transform.TransformDirection(moveDirection);

            // �ϥΥ��a�Ŷ���V�i�沾��
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
