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
