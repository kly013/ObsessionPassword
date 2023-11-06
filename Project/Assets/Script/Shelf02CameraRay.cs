using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf02CameraRay : MonoBehaviour
{
    Ray Camera02Ray;
    float raylength = 1.5f;
    static public RaycastHit Camera02hit;

    public GameObject[] ShelfCameraMove;
    public GameObject ShelfCamera;
    public GameObject BackButton;

    public GameObject CameraMain;
    public GameObject CursorPNG;

    bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        BackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Camera02Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(Camera02Ray, out Camera02hit, raylength))
        {
            Debug.DrawLine(Camera02Ray.origin, Camera02hit.point, Color.blue);
        }

        if (CameraControl.CursorControl == true)
        {
            CursorVisible();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isStart = true;
        }

        if (isStart)
        {
            if (Input.GetMouseButton(0))
            {
                if (Camera02hit.collider != null && Camera02hit.collider.gameObject != null)
                {
                    ClickObjectCameraMove();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CursorPNG.SetActive(true);
            CameraMain.SetActive(true);
            ShelfCamera.SetActive(false);
            ShelfCamera.transform.position = new Vector3(0.01f, -0.72f, 0.9f);
            GameObject.Find("Player").GetComponent<RayScript>().enabled = true;
            BackButton.SetActive(false);

        }
        // Debug.Log(ShelfCamera.transform.position);
    }

    void CursorVisible()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ClickObjectCameraMove()
    {
        if (Camera02hit.collider.gameObject == ShelfCameraMove[0])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[1])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[2])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[3])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject == ShelfCameraMove[4])
        {
            ShelfCamera.transform.position = new Vector3(-0.298f, -0.521f, 1.806f);
            BackButton.SetActive(true);
        }

        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[5].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.518f, 1.808f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[6].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.518f, 1.808f);
            BackButton.SetActive(true);
        }

        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[7].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.894f, 1.581f);
            BackButton.SetActive(true);
        }
        if (Camera02hit.collider.gameObject.name == ShelfCameraMove[8].name)
        {
            ShelfCamera.transform.position = new Vector3(0.146f, -0.894f, 1.581f);
            BackButton.SetActive(true);
        }
    }

    public void BackButtonClick()
    {
        ShelfCamera.transform.position = new Vector3(0.01f, - 0.72f, 0.9f);
        BackButton.SetActive(false);
    }
}
