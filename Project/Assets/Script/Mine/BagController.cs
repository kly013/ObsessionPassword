using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{
    // �Ҧ��i�H���������~
    enum Tools
    {
        AluminumCan001,
        AluminumCan002,
        AluminumCan003,
        AluminumCan004,
        Book001,
        Book002,
        Book003,
        Book004,
        Book005,
        Book006,
        Book007,
        Book008,
        Book010,
        Book011,
        Book012,
        Book014,
        Book015,
        Book016,
        Charger,
        ContactBook,
        Diary,
        DogBowl001,
        DogBowl002,
        DogCollar,
        Flour001,
        Flour002,
        Flour003,
        Flower,
        IceCreamBox001,
        IceCreamBox002,
        IceCreamBox003,
        Magnifier,
        Milk001,
        Milk002,
        Paste,
        Pen001,
        Pen002,
        Pen003,
        Pen004,
        Pen005,
        Pen006,
        Pen007,
        Photo2020,
        PhotoDog,
        PhotoFrame,
        PopsicleBox001,
        PopsicleBox002,
        PopsicleBox003,
        PopsicleBox004,
        Scissors,
        Seasoning001,
        Seasoning002,
        Seasoning003,
        Seasoning004,
        Seasoning005,
        Watermelon001,
        Watermelon002,
        Wine001,
        Wine002,
        Wine003
    }

    // �����Ϥ�
    public Sprite[] toolsImg;
    // �Ϥ���ܦ�m
    public GameObject[] imgPos;
    // �D��s��
    int toolsNum = 0;
    // ���V�D�����s���A��U�@�D��ө��
    public static int posNum = 0;

    // ���o���~�s�W�ܹD����
    public void addTools(GameObject obj)
    {
        // �h��(clone)��r
        string name = obj.name.Substring(0, obj.name.Length - 7);

        // �p�G��Tools���ҦC�D��A�h�X�{�۹����Ϥ�
        try
        {
            // �ȩ�
            //print(name);

            // ���լO�_��Tools�ҦC�D��
            Tools result = (Tools)Enum.Parse(typeof(Tools), name);
            // ���h���o�D��s��
            toolsNum = (int)result;
            // �N�ثe�ҫ��V�D�����Ϥ����
            imgPos[posNum].SetActive(true);
            // ���o�����Image
            Image img = imgPos[posNum].GetComponent<Image>();
            // �����D���
            img.sprite = toolsImg[toolsNum];
            // �N�����V�U�@�Ӧ�m(?!)
            posNum++;
        }
        catch
        {
            // �ȩ�
            //print("not found");
        }
    }

    // �ᱼ�D��A�D�㴫��
    public void onChangePos(string name)
    {
        // �T�ӹD����쪺image
        Image img1;
        Image img2;
        Image img3;

        // ��X���~���Ĥ@��쪫�~
        if (name == "Tool01")
        {
            // �ȩ�
            //print("tool01");

            // ���o�D����쪺image
            img1 = imgPos[0].GetComponent<Image>();
            img2 = imgPos[1].GetComponent<Image>();

            // �p�G�ĤG���O��ܪ��A
            if (imgPos[1].activeSelf)
            {
                // �N�ĤG��쪺�Ϥ����Ĥ@���
                img1.sprite = img2.sprite;
                // ���N�ĤG�������
                imgPos[1].SetActive(false);
                // �N���V��촫���ĤG���
                posNum = 1;

                // ���o�D����쪺image
                img3 = imgPos[2].GetComponent<Image>();
                // �p�G�ĤT���O��ܪ��A
                if (imgPos[2].activeSelf)
                {
                    // �N�ĤT��쪺�Ϥ����ĤG���
                    img2.sprite = img3.sprite;
                    // �N�ĤG���אּ���
                    imgPos[1].SetActive(true);
                    // �N�ĤT�������
                    imgPos[2].SetActive(false);
                    // ���V��쬰�ĤT���
                    posNum = 2;
                }
            }
            // �D��ܪ��A�A�h��D�����u���@�D��A�ᱼ�ߤ@�D��
            else
            {
                // �����N�Ĥ@�������
                imgPos[0].SetActive(false);
                // ���V��쬰�Ĥ@���
                posNum = 0;
            }
        }

        // ��X���~���ĤG��쪫�~
        if (name == "Tool02")
        {
            // �ȩ�
            //print("tool02");

            // ���o�D����쪺image
            img2 = imgPos[1].GetComponent<Image>();
            img3 = imgPos[2].GetComponent<Image>();

            // �p�G�ĤT���O��ܪ��A
            if (imgPos[2].activeSelf)
            {
                // �N�ĤT��쪺�Ϥ����ĤG���
                img2.sprite = img3.sprite;
                // �N�ĤG���אּ���
                imgPos[1].SetActive(true);
                // �N�ĤT�������
                imgPos[2].SetActive(false);
                // ���V��쬰�ĤT���
                posNum = 2;
            }
            // �Y�ĤT��쬰���ê��A�A��즳�ⶵ�D��
            else
            {
                // �N�ĤG�������
                imgPos[1].SetActive(false);
                // ���V�ĤG���
                posNum = 1;
            }
        }

        // ��X���~���ĤT��쪫�~
        if (name == "Tool03")
        {
            // �ȩ�
            //print("tool03");

            // �N�ĤT�������
            imgPos[2].SetActive(false);
            // ���V�ĤT���
            posNum = 2;
        }
    }
}
