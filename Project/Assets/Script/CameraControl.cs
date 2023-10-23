using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject CameraMain;
    public GameObject Camera01;
    public GameObject Cursor;

    static public bool CursorControl;
    // Start is called before the first frame update
    void Start()
    {
        CameraMain.SetActive(true);
    }

    private void Awake()
    {
        Camera01.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    CursorControl = true;
        //    Cursor.SetActive(false);
        //    Camera01.SetActive(true);
        //    CameraMain.SetActive(false);
        //    GameObject.Find("Player").GetComponent<RayScript>().enabled = false;
        //}
    }

    void ClickTable02()
    {
        CursorControl = true;
        Cursor.SetActive(false);
        Camera01.SetActive(true);
        CameraMain.SetActive(false);
        GameObject.Find("Player").GetComponent<RayScript>().enabled = false;
    }
}
