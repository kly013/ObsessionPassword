using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // �w�q����ҹ��
    public static CameraController instance;

    // �����F�ӫ�
    public float sensitivity = 2f;
    // ���a���⪺ Transform �ե�
    public Transform playerTransform; 

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
        // ������в��ʪ������q
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // �ھڹ��а����q������v��
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        // �N��v���ھګ������ਤ�ױ���
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // �N���a���⪺�������ਤ���ഫ���|����
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
