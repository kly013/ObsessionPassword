using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // �w�q����ҹ��
    public static CameraController instance;

    // ����F�ӫ�
    public float sensitivity = 3f;
    // ���a Transform 
    public Transform playerTra; 
    // ���������
    private float verticalRotation = 0f;

    void Awake()
    {
        // �T�O����ҼҦ�
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Start()
    {
        // ���è���w���Ш�̹�����
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (!LevelText01.isTalking)
        {
            // �ƹ����ʰ����q
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // �p������
            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

            // �̫������ਤ�ױ���
            transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

            // �N���a���⪺�������ਤ���ഫ���|����
            playerTra.Rotate(Vector3.up * mouseX);
        }
    }
}
