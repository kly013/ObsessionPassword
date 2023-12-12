using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText02 : MonoBehaviour
{
    // �P�_�O�_�b�ݹ��
    public static bool isTalking;

    bool isThose;
    bool notHear;

    // ��ܮ�
    public GameObject DialogueBG;
    // ��ܮؤ�r
    public Text ObjTalk;
    // �ťճB���s
    public GameObject clickSpace;

    string objtext = "";

    // notHearText ��k
    public void notHearText(string gameobjName)
    {
        notHear = true;
        GenerateObjectDescription(gameobjName);
    }

    // canHearText ��k
    public void canHearText(string gameobjName)
    {
        notHear = false;
        GenerateObjectDescription(gameobjName);
    }

    // �ͦ�����y�z��r����k
    private void GenerateObjectDescription(string gameobjName)
    {
        // �P�_�������O
        string objectType = GetObjectType(gameobjName);

        isThose = true;

        switch (objectType)
        {
            case "BanyanTree":
                objtext = notHear ? "�a��" : "�o�ӿN�F�|���ͤj�q���ϡA���ӾA�X���ӷ��N�C";
                break;
            case "BanyanTree_Branches":
                objtext = notHear ? "��������K�C" : "�a�𪺾�K�C";
                break;
            case "BanyanTree_Leaf":
                objtext = notHear ? "�����D����𪺾𸭡C" : "�a�𪺸��l�C";
                break;
            case "BanyanTreeHome":
                objtext = notHear ? "��L�����j��C" : "�٦n�٦��o�̥i�H���B�C";
                break;
            case "CamphorTree":
                objtext = notHear ? "����" : "�o�Ӥ��Y���@�ӭ��������D�C";
                break;
            case "CamphorTree_Branches":
                objtext = notHear ? "��������K�C" : "���𪺾�K�C";
                break;
            case "CamphorTree_Leaf":
                objtext = notHear ? "�����D����𪺾𸭡C" : "���𪺸��l�C";
                break;
            case "WaxTree":
                objtext = notHear ? "�ػ���" : "�ڰO�o�o��ܾA�X��U�ơC";
                break;
            case "WaxTree_Branches":
                objtext = notHear ? "��������K�C" : "�ػ��𪺾�K�C";
                break;
            case "WaxTree_Leaf":
                objtext = notHear ? "�����D����𪺾𸭡C" : "�ػ��𪺸��l�C";
                break;
            case "Battery":
                objtext = notHear ? "�Ӧn�F�A�i�H���S�q�����~�󴫹q���F�C" : "�H�����F��A�����D�O����C";
                break;
            case "Bone":
                objtext = notHear ? "���Y" : "���Y";
                break;
            case "Branches":
                objtext = notHear ? "��������K�C" : "���ӥͤ��ܦn�ΡC";
                break;
            case "Cloth":
                objtext = notHear ? "�ݰ_�ӬO���������ơC" : "�㵪�����A�\�ۧ�N�F�C";
                break;
            case "Group":
                objtext = notHear ? "�˶򪺬\��" : "��n�ܤj�ܾA�X���פѼġC";
                break;
            case "Lighter":
                objtext = notHear ? "�������I���_�ӡC�٦��@�I�U�ƥi�H�ΡA�n���˥X�өO�H" : "�̭����G��O�ܴΪ��U�ơA���]�ܮe���C���˪L�j���C";
                break;
            case "Matches":
                objtext = notHear ? "�O����A������I���_�ӡC" : "�H�����I���u��A����z�F�L�k���Q�I�U�C";
                break;
            case "FlashLight":
                objtext = notHear ? "��q���A�S�q�F�ݭn���q���C" : "�C���Q�Ө체�����n�h�C";
                break;
            case "Pistacia":
                objtext = notHear ? "�׽���" : "�ڰO�o�o��ܾA�X��U�ơC";
                break;
            case "Pistacia_Branches":
                objtext = notHear ? "��������K�C" : "�׽��쪺��K�C";
                break;
            case "Pistacia_Leaf":
                objtext = notHear ? "�����D����𪺾𸭡C" : "�׽��쪺���l�C";
                break;
            case "RoundStone":
                objtext = notHear ? "��ꪺ���Y�A�ݵ��Z�i�R���C" : "�O�򨺨ǥ��Y�A���ܮe���^�ˡC";
                break;
            case "SharpStone":
                objtext = notHear ? "�y�U�����Y�A�@���p�߸I��i��|���ˡC" : "��w�S�y�����Y�A�X�}�a�F��A�������ۼ������ܦn���ٷ|���ͤp����C";
                break;
            case "SmoothStone":
                objtext = notHear ? "�O�l�몺���Y�A�ݰ_�ӥi�H��[�l�C" : "�Ψӹj�}���㪺�a�O�A���ެO���y���٬O�y�@�𮧳��ܤ�K�C";
                break;
            case "StoneTiger":
                objtext = notHear ? "�f���檺�۪�A�ݰ_�ӫD�`��z" : "�O�f�f�A�ݭn���I�h��O�x���F��~��";
                break;
            // ��������
            default:
                isThose = false;
                break;
        }

        // ��ܹ�ܮ�
        ShowDialogue();
    }

    // ��ܹ�ܮت���k
    private void ShowDialogue()
    {
        if (isThose)
        {
            isTalking = true;
        }
        if (isTalking)
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = objtext;
            clickSpace.SetActive(true);
        }
    }

    // ���o�������O
    private string GetObjectType(string objName)
    {
        // �ˬd�W�٬O�_�]�t�A��
        if (objName.Contains("(") && objName.EndsWith(")"))
        {
            // �����A���Ψ䤺�e
            objName = objName.Substring(0, objName.LastIndexOf('('));
        }

        int index = objName.IndexOfAny("0123456789".ToCharArray()); // ���Ĥ@�ӼƦr������
        if (index != -1)
        {
            return objName.Substring(0, index);
        }
        return objName; // �p�G�S���Ʀr�A��^��l�W��
    }
}

