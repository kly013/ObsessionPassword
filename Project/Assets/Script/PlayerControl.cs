using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float rotatSpeed;
    public float smoothSpeed;

    float xRotation = 0;
    float yRotation = 0;

    // Update is called once per frame
    void Update()
    {
        float h = -Input.GetAxis("Horizontal");
        float v = -Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(h, 0, v).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection = new Vector3(moveDirection.x, 0, moveDirection.z);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        float mouseX = -Input.GetAxis("Mouse X") * rotatSpeed * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * rotatSpeed * Time.deltaTime;

        if (h == 0 && v == 0)
        {
            if (Mathf.Abs(mouseX) >= Mathf.Abs(mouseY))
            {
                yRotation -= mouseX;
            }
            else
            {
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            }

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }
        else
        {
            Vector3 roat = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }

        if (RayScript.isTalking == true)
        {
            moveSpeed = 0;
            rotatSpeed = 0;
            
        }
        else
        {
            moveSpeed = 1;
            rotatSpeed= 100;
        }
    }
}
