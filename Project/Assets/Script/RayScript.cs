using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{

    Ray ray;
    float raylength = 1.5f;
    static public RaycastHit hit;

    public GameObject PressE;

    public string[] Tags;

    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
<<<<<<< HEAD
        DialogueBG.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
=======
>>>>>>> origin/main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (isTalking == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }



=======
>>>>>>> origin/main
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //����v���g��O�e�����������g�u

        if (Physics.Raycast(ray, out hit, raylength))
        // (�g�u,out �Q�g�u���쪺����,�g�u����)�Aout hit �N��O�G��"�Q�g�u���쪺����"�a��hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            HitByRaycast2();

            //�V�Q�g�u���쪺����I�s�W��"HitByRaycast"����k�A���ݭn�Ǧ^��

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //��g�u���쪫��ɷ|�bScene�����e�X���u�A��K�d�\

            //print("�o�Ӧb�g�u�W�r�O"+hit.transform.name);
            //print("�o��Tag�O"+hit.transform.tag);
            //�bConsole�����L�X�Q�g�u���쪺����W�١A��K�d�\                       
        }

<<<<<<< HEAD
        if (Input.GetMouseButton(0))
        {
            for (int i = 0; i < ClickObjTalk.Length; i++)
            {

                if (hit.transform.gameObject == ClickObjTalk[i])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;

                }


            }
            RayOnUI();
            ClickObjectDialogueText();
            ClickTable();
        }
    }


    void ClickTable()
    {
        if(hit.collider.gameObject.name== "Table002")
        {
            hit.transform.SendMessage("ClickTable02", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }


    void RayOnUI()
    {

        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        {

            Debug.Log("�I��");

        }
=======
>>>>>>> origin/main
    }

    void HitByRaycast2()
    {

        foreach (string tag in Tags)
        {
            if (string.Equals(tag, hit.transform.tag))
            {
                
                PressE.SetActive(true);
                break;

            }
            else
            {

                PressE.SetActive(false);

            }

        }


    }

<<<<<<< HEAD
    void ClickObjectDialogueText()
    {
        if (RayScript.hit.collider.gameObject == ClickObjTalk[0])
        {
            ObjTalk.text = "�@�i���q����";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[1])
        {
            ObjTalk.text = "�@�Ӭݰ_�ӫܦn�Y���J�|";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[2])
        {
            ObjTalk.text = "�@�ﴶ�q���@�~��";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[3])
        {
            ObjTalk.text = "�@�ﴶ�q���@�~��";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[4])
        {
            ObjTalk.text = "�@�ﴶ�q���@�~��";
        }

        if (RayScript.hit.collider.gameObject == ClickObjTalk[5])
        {
            ObjTalk.text = "�����}�A���ӬO�S�q";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[6])
        {
            ObjTalk.text = "�@�i���q���Ȥl";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[7])
        {
            ObjTalk.text = "�ݰ_�ӴN�O���q���R�q�u";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[8])
        {
            ObjTalk.text = "�ݰ_�ӬO�ݷݪ���A";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[9])
        {
            ObjTalk.text = "�ݰ_�ӫܴ��q���@��";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[10])
        {
            ObjTalk.text = "�n�h���}��";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[11])
        {
            ObjTalk.text = "���q������";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[12])
        {
            ObjTalk.text = "�ݰ_�ӫܴ��q������";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[13])
        {
            ObjTalk.text = "���q����";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[14])
        {
            ObjTalk.text = "���q����";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[15])
        {
            ObjTalk.text = "�n���n�Q�Y";
        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[16])
        {
            ObjTalk.text = "���n���O��";
        }

        if (RayScript.hit.collider.gameObject == ClickObjTalk[17])
        {
            ObjTalk.text = "�ݰ_�ӹ����q���}�ƸJ";

        }
        if (RayScript.hit.collider.gameObject == ClickObjTalk[18])
        {
            ObjTalk.text = "�ݰ_�ӹ����q���}�ƸJ";
        }




    }

    public void ButtonClick()
    {
        isTalking = false;
        DialogueBG.SetActive(false);
    }




=======
>>>>>>> origin/main
}
