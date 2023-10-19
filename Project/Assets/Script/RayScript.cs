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
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //由攝影機射到是畫面正中央的射線

        if (Physics.Raycast(ray, out hit, raylength))
        // (射線,out 被射線打到的物件,射線長度)，out hit 意思是：把"被射線打到的物件"帶給hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);

            HitByRaycast2();

            //向被射線打到的物件呼叫名為"HitByRaycast"的方法，不需要傳回覆

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //當射線打到物件時會在Scene視窗畫出黃線，方便查閱

            //print("這個在射線名字是"+hit.transform.name);
            //print("這個Tag是"+hit.transform.tag);
            //在Console視窗印出被射線打到的物件名稱，方便查閱                       
        }

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

}
