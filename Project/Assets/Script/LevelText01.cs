using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText01 : MonoBehaviour
{
    // �P�_�O�_�b�ݹ��
    static public bool isTalking;
    bool isThose;

    // ��ܮ�
    public GameObject DialogueBG;
    //��ܮؤ�r
    public Text ObjTalk;
    // �ťճB���s
    public GameObject clickSpace;

    string objtext = "";

    public void notHearText(string gameobjName)
    {
        isThose = true;
        switch (gameobjName)
        {
            case "Bed":
            case "Pillow":
                objtext = "�౵��h�֨��ߪ��j��";
                break;
            case "BirthdayCake":
                objtext = "���K�X�n���ͤ�J�|";
                break;
            case "Book001":
            case "Book002":
            case "Book003":
            case "Book004":
            case "Book005":
            case "Book006":
            case "Book007":
            case "Book008":
                objtext = "���ѴN�O�O�q";
                break;
            case "Book009":
                objtext = "�O���ۮɥ��y�u�����¤�O���A�����D�̭����S���õۤ��򯵱K�C";
                break;
            case "Book010":
            case "Book011":
            case "Book012":
                objtext = "����ѾǨ��";
                break;
            case "Book014":
            case "Book015":
            case "Book016":
                objtext = "�禬�W�Ҥ��e���S��Ū�J���U";
                break;
            case "Bowl001":
            case "Bowl002":
            case "Bowl003":
                objtext = "�ӤH���p�J";
                break;
            case "Bowl004":
                objtext = "�i�H�˨F�Ԫ��J";
                break;
            case "Bowl005":
                objtext = "�j�J��";
                break;
            case "ContactBook":
                objtext = "�Ѯv��a���p��������";
                break;
            case "Cellphone":
                objtext = "�O���z������A���n���S�q�F�C";
                break;
            case "Chair001":
                objtext = "�p���l";
                break;
            case "Chair002":
                objtext = "�����l";
                break;
            case "Chair003":
                objtext = "�X�n�ξA���Ȥl";
                break;
            case "Chair004":
            case "Chair005":
            case "Chair006":
                objtext = "���U�y��";
                break;
            case "Chair007":
                objtext = "���O��";
                break;
            case "Chair008":
                objtext = "�@�몺���Y�Ȥl";
                break;
            case "Clock":
                objtext = "���ª������A���n�����|��";
                break;
            case "Clothes":
            case "Clothes006":
            case "Clothes007":
            case "Clothes008":
            case "Clothes009":
                objtext = "����í������A";
                break;
            case "Cup001":
            case "Cup002":
            case "Cup003":
            case "Cup004":
            case "Cup005":
                objtext = "�U���U�˪��M�l";
                break;
            case "CuttingBoard001":
            case "CuttingBoard002":
            case "CuttingBoard003":
                objtext = "�i�H�b�W������";
                break;
            case "DeskLamp":
                objtext = "�ܺ}�G���i�O";
                break;
            case "DogFoods":
                objtext = "�����D�n��q�ӷ�";
                break;
            case "Charger":
                objtext = "�N�q�O�`�J������R�q��";
                break;
            case "Chipsticks":
                objtext = "�F���a���D�n�\��";
                break;
            case "ForkAndSpoon":
                objtext = "���ͩM�e�l�����K";
                break;
            case "Flour001":
            case "Flour002":
            case "Flour003":
                objtext = "�ܦh�������ѯ��A���ѭ��ܤ�K�C";
                break;
            case "Flower001":
            case "Flower002":
            case "Flower003":
            case "PottedPlant":
                objtext = "�˹��Ϊ�����֮�";
                break;
            case "GasStove":
                objtext = "�Ʋz�T�\�����n�l��";
                break;
            case "IceCreamBox001":
            case "IceCreamBox002":
            case "IceCreamBox003":
                objtext = "�����L�骺��ū";
                break;
            case "Kennel":
                objtext = "�X�n�ξA������";
                break;
            case "Letter001":
            case "Letter002":
            case "Letter003":
            case "Letter004":
                objtext = "�n�h���H�A���O�å��}�ݦn�F";
                break;
            case "Magnifier":
                objtext = "�ݤ��M�Ӥp���r�ɴN�n�Ω�j��";
                break;
            case "MonthlyCalendar":
                objtext = "�O�����n�Ʊ����";
                break;
            case "Pan":
                objtext = "����n�Ϊ�������";
                break;
            case "Paste":
                objtext = "�߽k�O�ѵM���H�X��";
                break;
            case "Pen001":
            case "Pen002":
            case "Pen003":
            case "Pen004":
            case "Pen005":
            case "Pen006":
            case "Pen007":
                objtext = "�Ѽg�����n�u��";
                break;
            case "PhotoFrame":
                objtext = "�Ӥ��̪��j�a�ݰ_�ӳ��ܶ}��";
                break;
            case "Plate001":
            case "Plate002":
            case "Plate003":
            case "Plate004":
            case "Plate005":
                objtext = "�\�h�����J�L";
                break;
            case "PopsicleBox002":
            case "PopsicleBox003":
            case "PopsicleBox004":
            case "PopsicleBox005":
                objtext = "�M�n�n�Y���B��";
                break;
            case "Milk":
                objtext = "���J�@�p������";
                break;
            case "AluminumCan001":
            case "AluminumCan002":
            case "AluminumCan003":
            case "AluminumCan004":
            case "Wine001":
            case "Wine002":
            case "Wine004":
                objtext = "�U���U�˪�����";
                break;
            case "Scissors":
                objtext = "�@��ŤM";
                break;
            case "Seasoning001":
            case "Seasoning002":
            case "Seasoning003":
            case "Seasoning004":
            case "Seasoning005":
                objtext = "�Ʋz���h�˭������ӷ�";
                break;
            case "Sink":
                objtext = "�и`���Τ�";
                break;
            case "Spatula":
            case "Spoon":
                objtext = "�N���Ϊ��p��";
                break;
            case "DogBowl001":
            case "DogBowl002":
                objtext = "�d���M�ݪ��J";
                break;
            case "DogCollar":
                objtext = "�Q�ᤩ�S��\��i�H�򪯪����q���D��";
                break;
            case "Watermelon001":
            case "Watermelon002":
                objtext = "�n�j�ݰ_�ӫܦn�Y�����";
                break;
            case "PhotoDog":
                objtext = "�@�i�������Ӥ�";
                break;
            default:
                isThose = false;
                break;
        }
        if(isThose)
        {
            isTalking = true;
        }
        if (isTalking && !LevelController.isClickComputer)
        {
            DialogueBG.SetActive(true);
            ObjTalk.text = objtext;
            if(!LevelController.isTakeLook)
            {
                clickSpace.SetActive(true);
            }
        }
    }

    public void canHearText(String gameobjName)
    {
        isThose = true;
        switch (gameobjName)
        {
            case "Bed":
            case "Pillow":
                objtext = "���w�X�ݷݤ��b�����]�W�h�ΡA�n�ŷx�I";
                break;
            case "BirthdayCake":
                objtext = "�̳��w�C�~��D�H�@�_���ݷݹL�ͤ�F�I";
                break;
            case "Book001":
            case "Book002":
            case "Book003":
            case "Book004":
            case "Book005":
            case "Book006":
            case "Book007":
            case "Book008":
                objtext = "�D�H�`���U�Ӭ�";
                break;
            case "Book009":
                objtext = "�ݷݨC�ѳ��|���X��";
                break;
            case "Book010":
            case "Book011":
            case "Book012":
                objtext = "�ݷݱ`�`���b�Ȥl�ݳo�ǪF��";
                break;
            case "Book014":
            case "Book015":
            case "Book016":
                objtext = "�D�H�n���ܤ����w�o�ǪF��";
                break;
            case "Bowl001":
            case "Bowl002":
            case "Bowl003":
            case "Bowl004":
            case "Bowl005":
            case "Plate001":
            case "Plate002":
            case "Plate003":
            case "Plate004":
            case "Plate005":
                objtext = "�̭��C�����|��n�h�n�Y������";
                break;
            case "ContactBook":
                objtext = "�D�H�C�ѳ��|���X�Ӭ�";
                break;
            case "Cellphone":
                objtext = "���ӳ��w�A�D�H���F����ݥL����ݧڦh";
                break;
            case "Chair001":
            case "Chair002":
            case "Chair003":
            case "Chair004":
            case "Chair005":
            case "Chair006":
            case "Chair007":
            case "Chair008":
                objtext = "���w��D�H�@�˺ۦb�W��";
                break;
            case "Clock":
                objtext = "�ݷ��`�|���Y�ݥ�";
                break;
            case "Clothes":
            case "Clothes006":
            case "Clothes007":
            case "Clothes008":
            case "Clothes009":
                objtext = "�ݷݨC�ѳ��|�藍�@�˪�";
                break;
            case "Cup001":
            case "Cup002":
            case "Cup003":
            case "Cup004":
            case "Cup005":
                objtext = "�ݷݩM�D�H���M�l��ڪ��J�@�ˡI �˳ܪ����|�ܦ�A�n�n���I";
                break;
            case "CuttingBoard001":
            case "CuttingBoard002":
            case "CuttingBoard003":
                objtext = "�ݷݵN�����ɭԱ`�|���X��";
                break;
            case "DogFoods":
                objtext = "�n���A�D��S�j�F�A�n�Q�Y�r~";
                break;
            case "Charger":
                objtext = "�D�H���|�⥦���ۨ��¶ª��F��";
                break;
            case "Chipsticks":
            case "ForkAndSpoon":
                objtext = "�ݷݷݸ�D�H�Y�����|�ΡA�����򤣯ઽ���μL�Y�O?";
                break;
            case "Flour001":
            case "Flour002":
            case "Flour003":
                objtext = "�����A���|�}�o��";
                break;
            case "Flower001":
            case "Flower002":
            case "Flower003":
            case "PottedPlant":
                objtext = "���X�����p�߼���";
                break;
            case "GasStove":
                objtext = "�D�H�M�ݷݳ��`�i�D�ڦM�I���n�a��";
                break;
            case "IceCreamBox001":
            case "IceCreamBox002":
            case "IceCreamBox003":
            case "PopsicleBox002":
            case "PopsicleBox003":
            case "PopsicleBox004":
            case "PopsicleBox005":
                objtext = "���M�ݷݤ��`���D�H�Y�A���D�H�C���Y���ܶ}��";
                break;
            case "Kennel":
                objtext = "���b�W����ı�ܷŷx�ΪA";
                break;
            case "Letter001":
            case "Letter002":
            case "Letter003":
            case "Letter004":
                objtext = "�ݷݱ`�|���X�Ӭ�";
                break;
            case "Magnifier":
                objtext = "�ݷݦ��ɭԷ|����";
                break;
            case "MonthlyCalendar":
                objtext = "�D�H�̳��w�]��ݷݩж��b�W���e�e";
                break;
            case "Pan":
                objtext = "�ݷݵN�����|��";
                break;
            case "Paste":
                objtext = "�D�H���ɭԷ|���Ӷ�b�F��W��";
                break;
            case "Pen001":
            case "Pen002":
            case "Pen003":
            case "Pen004":
            case "Pen005":
            case "Pen006":
            case "Pen007":
                objtext = "�D�H�`�`���ۤ����D�b������";
                break;
            case "PhotoFrame":
                objtext = "�h�~�ݷݥͤ�n�n���I�@���]�ܴ��ݤ��~��......";
                break;
            case "Milk":
                objtext = "�D�H�̳��w�ܪ��I��ڳ��w�ܪ��C��@�ˡI";
                break;
            case "AluminumCan001":
            case "AluminumCan002":
            case "AluminumCan003":
            case "AluminumCan004":
            case "Wine001":
            case "Wine002":
            case "Wine004":
                objtext = "�D�H�`�`�X�ݷݤ��b����";
                break;
            case "Scissors001":
            case "Scissors002":
                objtext = "�ݰ_�Ӷ�ꪺ�A���D�H�`�O�����ڸI";
                break;
            case "Seasoning001":
            case "Seasoning002":
            case "Seasoning003":
            case "Seasoning004":
            case "Seasoning005":
                objtext = "�ݷݵN�泣�|�[�A�ڤ]�Q�Y�ݬݡA���ݷ��`�O������";
                break;
            case "Sink":
                objtext = "���F�ڳ��ۤv���}�ܡA���ѰO�����ɭԳ��Q�|";
                break;
            case "Spatula":
            case "Spoon":
                objtext = "�ݷݵN�����|�Ψ�";
                break;
            case "DogBowl001":
            case "DogBowl002":
                objtext = "�n�Q�n�̭��@���˺�����";
                break;
            case "DogCollar":
                objtext = "�i�H�����������q";
                break;
            case "Watermelon001":
            case "Watermelon002":
                objtext = "�D�H�M�ݷݨC���Y�o�Ӭݰ_�ӳ��ܶ}��";
                break;
            default:
                isThose = false;
                break;
        }
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
}
