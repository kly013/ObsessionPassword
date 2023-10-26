using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TableCameraRay : MonoBehaviour
{
    Ray Camera01Ray;
    float raylength = 1.5f;
    static public RaycastHit Camera01hit;

    public GameObject[] ObjectClickText;
    public GameObject DialogueBG;
    public Text ObjTalk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera01Ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(Camera01Ray, out Camera01hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {

            CursorVisible();
            Debug.DrawLine(Camera01Ray.origin, Camera01hit.point, Color.red);


        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("點擊");
            ClickObjectDialogueText();
        }
        if (CameraControl.CursorControl == true)
        {
            CursorVisible();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera01hit.transform.SendMessage("BackToMainCamera", gameObject, SendMessageOptions.DontRequireReceiver);
        }

    }

    void CursorVisible()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ClickObjectDialogueText()
    {
        
        if (Camera01hit.collider.gameObject == ObjectClickText[0])
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "信";
        }
        if (Camera01hit.collider.gameObject == ObjectClickText[1])
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "普通的放大鏡，有放大字的功能";
        }
        if (Camera01hit.collider.gameObject == ObjectClickText[2])
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "全家福";
        }
        if (Camera01hit.collider.gameObject == ObjectClickText[3])
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = "桌燈";
        }
    }
}
