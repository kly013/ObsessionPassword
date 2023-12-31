using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCellphone : MonoBehaviour
{
    public Text topTimeHr;
    public Text topTimeMin;
    public Text centerTimeHr;
    public Text centerTimeMin;

    public GameObject dia;

    int h;
    int m;

    private void Update()
    {
        h = ClickComputer.hr;
        m = ClickComputer.min;

        if (m < 10)
        {
            topTimeMin.text = "0" + m;
            centerTimeMin.text = "0" + m;
        }
        else
        {
            topTimeMin.text =  m.ToString();
            centerTimeMin.text = m.ToString();
        }

        if (h < 10)
        {
            topTimeHr.text = "0" + h;
            centerTimeHr.text = "0" + h;
        }
        else
        {
            topTimeHr.text = h.ToString();
            centerTimeHr.text = h.ToString();
        }
        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            dia.SetActive(false);
            this.gameObject.SetActive(false);
            LevelText01.isTalking = false;
        }
    }

    public void onClick()
    {
        dia.SetActive(true);
    }
}
