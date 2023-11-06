using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject CameraMain;
    public GameObject Camera01;
    public GameObject Camera02;
    public GameObject Cursor;
    public GameObject BackButton;

    static public bool CursorControl;

    void Start()
    {
        CameraMain.SetActive(true);
        BackButton.SetActive(false);
    }

    private void Awake()
    {
        Camera01.SetActive(false);
        Camera02.SetActive(false);
    }

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

    void ClickBedRoomTable()
    {
        CursorControl = true;
        Cursor.SetActive(false);
        Camera01.SetActive(true);
        CameraMain.SetActive(false);
        GameObject.Find("Player").GetComponent<RayScript>().enabled = false;
    }

    void ClickShelf()
    {
        CursorControl = true;
        Cursor.SetActive(false);
        Camera02.SetActive(true);
        Camera02.transform.position = new Vector3(0.01f, -0.72f, 0.9f);
        Debug.Log(Camera02.transform.position);
        CameraMain.SetActive(false);
        GameObject.Find("Player").GetComponent<RayScript>().enabled = false;
    }

    void BackToMainCamera()
    {
        Cursor.SetActive(true);
        CameraMain.SetActive(true);
        Camera01.SetActive(false);
        Camera02.SetActive(false);
        GameObject.Find("Player").GetComponent<RayScript>().enabled = true;
    }
}
