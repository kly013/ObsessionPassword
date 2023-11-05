using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{

    Ray ray;
    float raylength = 1.5f;
    static public RaycastHit hit;

    public GameObject PressE;

    public string[] Tags;

    static public bool isTalking = false;
    public GameObject[] ClickObjTalk;
    public GameObject[] DogListener;
    public GameObject DialogueBG;
    public Text ObjTalk;
    static public bool CanHearDog=false;

    public GameObject CameraShelf;
    
    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
        DialogueBG.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
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



        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //����v���g��O�e�����������g�u

        if (Physics.Raycast(ray, out hit, raylength) && !EventSystem.current.IsPointerOverGameObject())
        // (�g�u,out �Q�g�u���쪺����,�g�u����)�Aout hit �N��O�G��"�Q�g�u���쪺����"�a��hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            PressEControl();

            //�V�Q�g�u���쪺����I�s�W��"HitByRaycast"����k�A���ݭn�Ǧ^��

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //��g�u���쪫��ɷ|�bScene�����e�X���u�A��K�d�\

            //print("�o�Ӧb�g�u�W�r�O"+hit.transform.name);
            //�bConsole�����L�X�Q�g�u���쪺����W�١A��K�d�\



        }

        if (Input.GetMouseButton(0))
        {

            if (hit.collider.gameObject.name == "DogCollar")
            {
                CanHearDog = true;
                
            }


            for (int i = 0; i < ClickObjTalk.Length; i++)
            {

                if (hit.transform.gameObject == ClickObjTalk[i])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;
                }

            }
            for(int r = 0; r < DogListener.Length; r++)
            {
                if (hit.transform.gameObject == DogListener[r])
                {
                    isTalking = true;
                    DialogueBG.SetActive(true);
                    break;
                }
            }



            if (CanHearDog == true)
            {
                HearDogText();
            }
            else
            {
                ClickObjectDialogueText();
            }
            
            ClickBedRoomTable();
            ClickShelf02();
        }
    }


    void ClickBedRoomTable()
    {
        if(hit.collider.gameObject.name== "Table002")
        {
            
            hit.transform.SendMessage("ClickBedRoomTable", gameObject, SendMessageOptions.DontRequireReceiver);
        }
    }

    void ClickShelf02()
    {
        if (hit.collider.gameObject.name == "Shelf002")
        {
            hit.transform.SendMessage("ClickShelf", gameObject, SendMessageOptions.DontRequireReceiver);
            
        }
    }



    void PressEControl()
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

    void ClickObjectDialogueText()
    {
        if (RayScript.hit.collider.gameObject == DogListener[0]) //���s�Y
        {
            ObjTalk.text = "�`���Τ��A�O�@�ͩR�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[1]) //���}��
        {
            ObjTalk.text = "���O�d�����w���}�ơC";
        }
        if (RayScript.hit.collider.gameObject == DogListener[2]) //�J�|
        {
            ObjTalk.text = "�o�J�|�ݰ_�Ӧn�n�Y�C";
        }

        if (RayScript.hit.collider.gameObject == DogListener[3]) //�@��
        {
            ObjTalk.text = "�©@�ءA�n�W�C";
        }

        if (RayScript.hit.collider.gameObject == DogListener[4]) //����
        {
            ObjTalk.text = "���@���A���C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[5]) //�B
        {
            ObjTalk.text = "�n���r�A�n�Q�Y�C";
        }

        if (RayScript.hit.collider.gameObject == DogListener[6]) //�Ȥl
        {
            ObjTalk.text = "���ꪺ���Y�ȡC";
        }

        if (RayScript.hit.collider.gameObject == DogListener[7]) //�@�~��
        {
            ObjTalk.text = "�@�|�@�~���A�Q��N�Y�h�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[8]) //�R�q�u
        {
            ObjTalk.text = "���j�n���R�q�u�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[9]) //��
        {
            ObjTalk.text = "�X�K���q�����C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[10]) //�ŤM
        {
            ObjTalk.text = "�w���ŤM�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[11]) //��
        {
            ObjTalk.text = "�\�h�ѥ��C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[12]) //���
        {
            ObjTalk.text = "�}���F���A���ӬO�S�q�F�C";
        }

        if (RayScript.hit.collider.gameObject == DogListener[13]) //����
        {
            ObjTalk.text = "�d�������ۡC";
        }
        if (RayScript.hit.collider.gameObject == DogListener[14]) //���J
        {
            ObjTalk.text = "�ˤ����d�����J�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[15]) //�}�ƸJ
        {
            ObjTalk.text = "���d���}�ƪ��J�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[16]) //��A
        {
            ObjTalk.text = "�Pı�O�ݷݪ���A�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[17]) //��
        {
            ObjTalk.text = "�ܤj�ܵΪA���ɡC";
        }




    }

    void HearDogText()
    {

        if (RayScript.hit.collider.gameObject == DogListener[0]) //���s�Y
        {
            ObjTalk.text = "���F�ڳ��ۤv���}�ܡA���ѰO�����ɭԳ��Q�|�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[1]) //���}��
        {
            ObjTalk.text = "�n���A�D��S�j�F�A�n�Q�Y�r~";
        }
        if (RayScript.hit.collider.gameObject == DogListener[2]) //�J�|
        {
            ObjTalk.text = "�̳��w�C�~��D�H�@�_���ݷݹL�ͤ�F�I";
        }

        if (RayScript.hit.collider.gameObject == DogListener[3]) //�@��
        {
            ObjTalk.text = "�ݷݥ��`�ܳ��w�ܳo�ӡC";
        }

        if (RayScript.hit.collider.gameObject == DogListener[4]) //����
        {
            ObjTalk.text = "�D�H�̳��w�ܪ��I��ڳ��w�ܪ��C��@�ˡI";
        }
        if (RayScript.hit.collider.gameObject == DogListener[5]) //�B
        {
            ObjTalk.text = "���M�ݷݤ��`���D�H�Y�A���D�H�C���Y���ܶ}�ߡC";
        }

        if (RayScript.hit.collider.gameObject == DogListener[6]) //�Ȥl
        {
            ObjTalk.text = "�D�H�`������m�A�����]�W�h�`�O�Q��U�ӡC";
        }

        if (RayScript.hit.collider.gameObject == DogListener[7]) //�@�~��
        {
            ObjTalk.text = "�D�H�n���ܤ����w�o�ǪF��C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[8]) //�R�q�u
        {
            ObjTalk.text = "����������D�H���n���b��W�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[9]) //��
        {
            ObjTalk.text = "�D�H�`�`���ۡC";
        }
        if (RayScript.hit.collider.gameObject == DogListener[10]) //�ŤM
        {
            ObjTalk.text = "�ݰ_�Ӷ�ꪺ�A���D�H�`�O�����ڸI�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[11]) //��
        {
            ObjTalk.text = "�D�H���`�|���U�ӬݡC";
        }
        if (RayScript.hit.collider.gameObject == DogListener[12]) //���
        {
            ObjTalk.text = "���ӳ��w�A�D�H���F����ݥL����ݧڦh�C";
        }

        if (RayScript.hit.collider.gameObject == DogListener[13]) //����
        {
            ObjTalk.text = "�ܬX�n�A���w�ݦb�W�����D�H�^�a�C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[14]) //���J
        {
            ObjTalk.text = "�ܤ����ɭԹϮ׷|�C�C�����A�ܦn���C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[15]) //�}�ƸJ
        {
            ObjTalk.text = "�n�Q�n�̭��@���˺������C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[16]) //��A
        {
            ObjTalk.text = "�ݷݨC�ѳ��|�藍�@�˪��C";
        }
        if (RayScript.hit.collider.gameObject == DogListener[17]) //��
        {
            ObjTalk.text = "���w�X�ݷݤ��b�����]�W�h�ΡA�n�ŷx�I";
        }

    
    }

    public void ButtonClick()
    {
        isTalking = false;
        DialogueBG.SetActive(false);
    }




}
