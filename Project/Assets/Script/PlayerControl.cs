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

        transform.Translate(h * moveSpeed * Time.deltaTime, 0, v * moveSpeed * Time.deltaTime, Space.World);

        //Move(moveSpeed * Time.deltaTime);

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
            //transform.rotation = Quaternion.Euler(0, yRotation, 0f);
            //transform.rotation = Quaternion.Euler(Vector3.Lerp(roat, new Vector3(0, yRotation, 0f), smoothSpeed));
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

   void Move(float speed)
    {
        // лe
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward * speed, Space.World);
            print("-forward = " + -transform.forward);
        }
        // лс
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * speed, Space.World);
            print("forward = " + transform.forward);
        }
        // ек
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * speed, Space.World);
            print("right = " + transform.right);
        }
        // еk
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-transform.right * speed, Space.World);
            print("-right = " + -transform.right);
        }
    }
}
