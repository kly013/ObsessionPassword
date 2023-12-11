using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText01 : MonoBehaviour
{
    // 判斷是否在看對話
    static public bool isTalking;
    bool isThose;

    // 對話框
    public GameObject DialogueBG;
    //對話框文字
    public Text ObjTalk;
    // 空白處按鈕
    public GameObject clickSpace;

    string objtext = "";

    public void notHearText(string gameobjName)
    {
        isThose = true;
        switch (gameobjName)
        {
            case "Bed":
            case "Pillow":
                objtext = "能接住疲累身軀的大床";
                break;
            case "BirthdayCake":
                objtext = "綿密柔軟的生日蛋糕";
                break;
            case "Book001":
            case "Book002":
            case "Book003":
            case "Book004":
            case "Book005":
            case "Book006":
            case "Book007":
            case "Book008":
                objtext = "知識就是力量";
                break;
            case "Book009":
                objtext = "記錄著時光流逝的老舊日記本，不知道裡面有沒有藏著什麼秘密。";
                break;
            case "Book010":
            case "Book011":
            case "Book012":
                objtext = "活到老學到老";
                break;
            case "Book014":
            case "Book015":
            case "Book016":
                objtext = "驗收上課內容有沒有讀入腦袋";
                break;
            case "Bowl001":
            case "Bowl002":
            case "Bowl003":
                objtext = "個人的小碗";
                break;
            case "Bowl004":
                objtext = "可以裝沙拉的碗";
                break;
            case "Bowl005":
                objtext = "大碗公";
                break;
            case "ContactBook":
                objtext = "老師跟家長聯絡的橋樑";
                break;
            case "Cellphone":
                objtext = "是智慧型手機，但好像沒電了。";
                break;
            case "Chair001":
                objtext = "小凳子";
                break;
            case "Chair002":
                objtext = "高凳子";
                break;
            case "Chair003":
                objtext = "柔軟舒適的椅子";
                break;
            case "Chair004":
            case "Chair005":
            case "Chair006":
                objtext = "客廳座椅";
                break;
            case "Chair007":
                objtext = "長板凳";
                break;
            case "Chair008":
                objtext = "一般的木頭椅子";
                break;
            case "Clock":
                objtext = "老舊的時鐘，但好像不會動";
                break;
            case "Clothes":
            case "Clothes006":
            case "Clothes007":
            case "Clothes008":
            case "Clothes009":
                objtext = "成熟穩重的衣服";
                break;
            case "Cup001":
            case "Cup002":
            case "Cup003":
            case "Cup004":
            case "Cup005":
                objtext = "各式各樣的杯子";
                break;
            case "CuttingBoard001":
            case "CuttingBoard002":
            case "CuttingBoard003":
                objtext = "可以在上面切菜";
                break;
            case "DeskLamp":
                objtext = "很漂亮的檯燈";
                break;
            case "DogFoods":
                objtext = "狗的主要能量來源";
                break;
            case "Charger":
                objtext = "將電力注入手機的充電器";
                break;
            case "Chipsticks":
                objtext = "東方國家的主要餐具";
                break;
            case "ForkAndSpoon":
                objtext = "湯匙和叉子比較方便";
                break;
            case "Flour001":
            case "Flour002":
            case "Flour003":
                objtext = "很多的高級麵粉，做麵食很方便。";
                break;
            case "Flower001":
            case "Flower002":
            case "Flower003":
            case "PottedPlant":
                objtext = "裝飾用的假花盆栽";
                break;
            case "GasStove":
                objtext = "料理三餐的重要爐具";
                break;
            case "IceCreamBox001":
            case "IceCreamBox002":
            case "IceCreamBox003":
                objtext = "炎炎夏日的救贖";
                break;
            case "Kennel":
                objtext = "柔軟舒適的狗窩";
                break;
            case "Letter001":
            case "Letter002":
            case "Letter003":
            case "Letter004":
                objtext = "好多的信，但別亂打開看好了";
                break;
            case "Magnifier":
                objtext = "看不清太小的字時就要用放大鏡";
                break;
            case "MonthlyCalendar":
                objtext = "記錄重要事情月曆";
                break;
            case "Pan":
                objtext = "樸素好用的平底鍋";
                break;
            case "Paste":
                objtext = "漿糊是天然的黏合劑";
                break;
            case "Pen001":
            case "Pen002":
            case "Pen003":
            case "Pen004":
            case "Pen005":
            case "Pen006":
            case "Pen007":
                objtext = "書寫的重要工具";
                break;
            case "PhotoFrame":
                objtext = "照片裡的大家看起來都很開心";
                break;
            case "Plate001":
            case "Plate002":
            case "Plate003":
            case "Plate004":
            case "Plate005":
                objtext = "許多陶瓷碗盤";
                break;
            case "PopsicleBox002":
            case "PopsicleBox003":
            case "PopsicleBox004":
            case "PopsicleBox005":
                objtext = "清爽好吃的冰棒";
                break;
            case "Milk":
                objtext = "香醇濃厚的牛奶";
                break;
            case "AluminumCan001":
            case "AluminumCan002":
            case "AluminumCan003":
            case "AluminumCan004":
            case "Wine001":
            case "Wine002":
            case "Wine004":
                objtext = "各式各樣的飲料";
                break;
            case "Scissors":
                objtext = "一把剪刀";
                break;
            case "Seasoning001":
            case "Seasoning002":
            case "Seasoning003":
            case "Seasoning004":
            case "Seasoning005":
                objtext = "料理中多樣香味的來源";
                break;
            case "Sink":
                objtext = "請節約用水";
                break;
            case "Spatula":
            case "Spoon":
                objtext = "煮飯用的廚具";
                break;
            case "DogBowl001":
            case "DogBowl002":
                objtext = "寵物專屬的碗";
                break;
            case "DogCollar":
                objtext = "被賦予特殊功能可以跟狗狗溝通的道具";
                break;
            case "Watermelon001":
            case "Watermelon002":
                objtext = "好大看起來很好吃的西瓜";
                break;
            case "PhotoDog":
                objtext = "一張狗狗的照片";
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
                objtext = "喜歡趁爺爺不在偷偷跑上去睡，好溫暖！";
                break;
            case "BirthdayCake":
                objtext = "最喜歡每年跟主人一起幫爺爺過生日了！";
                break;
            case "Book001":
            case "Book002":
            case "Book003":
            case "Book004":
            case "Book005":
            case "Book006":
            case "Book007":
            case "Book008":
                objtext = "主人常拿下來看";
                break;
            case "Book009":
                objtext = "爺爺每天都會拿出來";
                break;
            case "Book010":
            case "Book011":
            case "Book012":
                objtext = "爺爺常常坐在椅子看這些東西";
                break;
            case "Book014":
            case "Book015":
            case "Book016":
                objtext = "主人好像很不喜歡這些東西";
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
                objtext = "裡面每次都會放好多好吃的食物";
                break;
            case "ContactBook":
                objtext = "主人每天都會拿出來看";
                break;
            case "Cellphone":
                objtext = "不太喜歡，主人有了之後看他都比看我多";
                break;
            case "Chair001":
            case "Chair002":
            case "Chair003":
            case "Chair004":
            case "Chair005":
            case "Chair006":
            case "Chair007":
            case "Chair008":
                objtext = "喜歡跟主人一樣窩在上面";
                break;
            case "Clock":
                objtext = "爺爺總會抬頭看它";
                break;
            case "Clothes":
            case "Clothes006":
            case "Clothes007":
            case "Clothes008":
            case "Clothes009":
                objtext = "爺爺每天都會穿不一樣的";
                break;
            case "Cup001":
            case "Cup002":
            case "Cup003":
            case "Cup004":
            case "Cup005":
                objtext = "爺爺和主人的杯子跟我的碗一樣！ 裝喝的都會變色，好好玩！";
                break;
            case "CuttingBoard001":
            case "CuttingBoard002":
            case "CuttingBoard003":
                objtext = "爺爺煮飯的時候常會拿出來";
                break;
            case "DogFoods":
                objtext = "好香，聞到又餓了，好想吃呀~";
                break;
            case "Charger":
                objtext = "主人都會把它接著那黑黑的東西";
                break;
            case "Chipsticks":
            case "ForkAndSpoon":
                objtext = "看爺爺跟主人吃飯都會用，為什麼不能直接用嘴吃呢?";
                break;
            case "Flour001":
            case "Flour002":
            case "Flour003":
                objtext = "不香，不會開這邊";
                break;
            case "Flower001":
            case "Flower002":
            case "Flower003":
            case "PottedPlant":
                objtext = "有幾次不小心撞倒";
                break;
            case "GasStove":
                objtext = "主人和爺爺都常告訴我危險不要靠近";
                break;
            case "IceCreamBox001":
            case "IceCreamBox002":
            case "IceCreamBox003":
            case "PopsicleBox002":
            case "PopsicleBox003":
            case "PopsicleBox004":
            case "PopsicleBox005":
                objtext = "雖然爺爺不常讓主人吃，但主人每次吃都很開心";
                break;
            case "Kennel":
                objtext = "躺在上面睡覺很溫暖舒服";
                break;
            case "Letter001":
            case "Letter002":
            case "Letter003":
            case "Letter004":
                objtext = "爺爺常會拿出來看";
                break;
            case "Magnifier":
                objtext = "爺爺有時候會拿著";
                break;
            case "MonthlyCalendar":
                objtext = "主人最喜歡跑到爺爺房間在上面畫畫";
                break;
            case "Pan":
                objtext = "爺爺煮飯都會用";
                break;
            case "Paste":
                objtext = "主人有時候會拿來塗在東西上面";
                break;
            case "Pen001":
            case "Pen002":
            case "Pen003":
            case "Pen004":
            case "Pen005":
            case "Pen006":
            case "Pen007":
                objtext = "主人常常拿著不知道在做什麼";
                break;
            case "PhotoFrame":
                objtext = "去年爺爺生日好好玩！一直也很期待今年的......";
                break;
            case "Milk":
                objtext = "主人最喜歡喝的！跟我喜歡喝的顏色一樣！";
                break;
            case "AluminumCan001":
            case "AluminumCan002":
            case "AluminumCan003":
            case "AluminumCan004":
            case "Wine001":
            case "Wine002":
            case "Wine004":
                objtext = "主人常常趁爺爺不在偷拿";
                break;
            case "Scissors001":
            case "Scissors002":
                objtext = "看起來圓圓的，但主人總是不讓我碰";
                break;
            case "Seasoning001":
            case "Seasoning002":
            case "Seasoning003":
            case "Seasoning004":
            case "Seasoning005":
                objtext = "爺爺煮菜都會加，我也想吃看看，但爺爺總是說不行";
                break;
            case "Sink":
                objtext = "渴了我都自己打開喝，但忘記關的時候都被罵";
                break;
            case "Spatula":
            case "Spoon":
                objtext = "爺爺煮飯都會用到";
                break;
            case "DogBowl001":
            case "DogBowl002":
                objtext = "好想要裡面一直裝滿滿的";
                break;
            case "DogCollar":
                objtext = "可以切換取消溝通";
                break;
            case "Watermelon001":
            case "Watermelon002":
                objtext = "主人和爺爺每次吃這個看起來都很開心";
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
