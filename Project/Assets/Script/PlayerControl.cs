using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // ���ʳt��
    public float movespeed = 1;
    float moveSpeed;
    // ���Y�t��
    public float rotatspeed = 100;
    float rotatSpeed;

    // �p�� xy �b����
    float xRotation = 0;
    float yRotation = 0;

    Vector3 moveDirection;

    void Update()
    {
        // ��V�q��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �N�ۨ��y���ন�@�ɮy�СA�O���H�ۨ��e�ᥪ�k��
        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection = new Vector3(moveDirection.x, 0, moveDirection.z);

        // �ƹ� xy �b�q��
        float mouseX = -Input.GetAxis("Mouse X") * rotatSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotatSpeed * Time.deltaTime;

        // �P�_���S���b����
        if (h == 0 && v == 0)
        {
            // ��ܥ��k��ΤW�U��
            if (Mathf.Abs(mouseX) >= Mathf.Abs(mouseY))
            {
                yRotation -= mouseX;
            }
            else
            {
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            }

            if (mouseX != 0 || mouseY != 0)
            {
                // ���
                transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
            }
        }
        else
        {
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
        }

        // �I���F��ᤣ�ʤ���
        if (LevelText01.isTalking)
        {
            moveSpeed = 0;
            rotatSpeed = 0;
        }
        else
        {
            moveSpeed = movespeed;
            rotatSpeed = rotatspeed;
        }
    }
}
