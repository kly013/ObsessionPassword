using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // ���ʳt��
    public float moveSpeed;
    // ���Y�t��
    public float rotatSpeed;

    // �p�� xy �b����
    float xRotation = 0;
    float yRotation = 0;

    void Update()
    {
        // ��V�q��
        float h = -Input.GetAxis("Horizontal");
        float v = -Input.GetAxis("Vertical");

        // �N�ۨ��y���ন�@�ɮy�СA�O���H�ۨ��e�ᥪ�k��
        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection = new Vector3(moveDirection.x, 0, moveDirection.z);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        // �ƹ� xy �b�q��
        float mouseX = -Input.GetAxis("Mouse X") * rotatSpeed * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * rotatSpeed * Time.deltaTime;

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

            // ���
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
        else
        {
            // ����
            Vector3 roat = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }

        // �I���F��ᤣ�ʤ���
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
