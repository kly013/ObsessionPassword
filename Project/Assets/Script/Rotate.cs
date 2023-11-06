using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour
{


    // Start is called before the first frame update
    //public GameObject RotateObj;
    Ray ray;
    float raylength = 1.5f;
    static public RaycastHit hit;


    float speeed = 3f;

    public GameObject[] RotateObj;
    float axisX;
    float axisY;



    void Update()
    {

        if (Input.GetMouseButton(2))
        {
            axisX = -Input.GetAxis("Mouse X");
            axisY = Input.GetAxis("Mouse Y");

        }
        else
        {
            axisX = 0;
            axisY = 0;
        }

        for (int i = 0; i < RotateObj.Length; i++)
        {
                RotateObj[i].transform.Rotate(new Vector3(axisY * speeed, axisX * speeed, 0), Space.World);
   
        }



    }
}
