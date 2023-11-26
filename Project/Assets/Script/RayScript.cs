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
    float raylength = 2f;
    // ���쪺�F��
    public static RaycastHit hit;
    // �P�_�O���Oť�o���ʪ��y
    bool CanHear = false;

    public static bool isHit = false;

    public LevelText01 levelText01;
    public ClickComputer clickComputer;
    public OpenDoor openDoor;
    public CameraControl cameraControl;

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

            if (Input.GetMouseButtonDown(0))
            {
                print(hit.transform.name);

                if (hit.collider.gameObject.tag == "key")
                {
                    //print(hit.collider.name);
                    CanHear = !CanHear;
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

                openDoor.HitByRaycast(hit.collider.name);
                //cameraControl.CameraChange(hit.collider.name);

                if (hit.collider.name == "Computer")
                {
                    clickComputer.OnClick();
                    LevelText01.isTalking = true;
                }
            }
        }
        else
        {
            isHit = false;
        }
    }
}
