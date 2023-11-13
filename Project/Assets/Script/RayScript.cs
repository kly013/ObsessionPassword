using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{
    // �g�u
    Ray ray;
    // �g�u����
    float raylength = 1.5f;
    // ���쪺�F��
    static public RaycastHit hit;

    public LevelText01 levelText01;

    // ��ܮ�
    public GameObject DialogueBG;
    // ���ťճB
    public GameObject clickSpace;

    // �P�_�O���Oť�o���ʪ��y
    bool CanHear = false;

    public static bool isHit = false;

    public ClickComputer clickComputer;
    public OpenDoor openDoor;

    void Start()
    {
        // �}�l�������ܩM��ܮ�
        //PressE.SetActive(false);
        //DialogueBG.SetActive(false);

        // ���г]�w������
        Cursor.lockState = CursorLockMode.Locked;
        // ���ù���
        Cursor.visible = false;
    }

    void Update()
    {
        // ��ܮ�
        if (LevelText01.isTalking)
        {
            // ���ХX�{
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // ��v���g��e�����������g�u
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        // (�g�u,out �Q�g�u���쪺����,�g�u����)�Aout hit �N��O�G��"�Q�g�u���쪺����"�a��hit
        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {
            isHit = true;

            //��g�u���쪫��ɷ|�bScene�����e�X���u�A��K�d�\
            Debug.DrawLine(ray.origin, hit.point, Color.yellow);

            //�bConsole�����L�X�Q�g�u���쪺����W�١A��K�d�\
            //print("�o�Ӧb�g�u�W�r�O" + hit.transform.name);

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.tag == "key")
                {
                    //print(hit.collider.name);
                    CanHear = true;
                }

                if (CanHear)
                {
                    //HearDogText();
                    levelText01.canHearText(hit.collider.name);
                }
                else
                {
                    //ClickObjectDialogueText();
                    levelText01.notHearText(hit.collider.name);
                }

                openDoor.HitByRaycast();

                if (hit.collider.name == "Computer")
                {
                    clickComputer.OnClick();
                    LevelText01.isTalking = true;
                }

                ClickBedRoomTable();
                ClickShelf02();
            }
        }
        else
        {
            isHit = false;
        }
    }

    void ClickBedRoomTable()
    {
        if(hit.collider.name== "Table002")
        {
            hit.transform.SendMessage("ClickBedRoomTable", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    void ClickShelf02()
    {
        if (hit.collider.name == "Shelf002")
        {
            hit.transform.SendMessage("ClickShelf", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    public void ButtonClick()
    {
        LevelText01.isTalking = false;
        DialogueBG.SetActive(false);
        clickSpace.SetActive(false);
    }
}
