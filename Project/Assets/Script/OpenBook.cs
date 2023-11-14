using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenBook : MonoBehaviour
{

    public GameObject openedbook;
    public GameObject insideBackcover;
    public AudioSource audioSource;
    public AudioClip OpenBookSound;
    public AudioClip CloseBookSound;
    private Vector3 rotationVector;
    bool isOpenClicked;
    bool isClosedClicked;
    DateTime startTime;
    DateTime endTime;
    // Start is called before the first frame update
    void Start()
    {

        AppEvent.Closebook += new EventHandler(closebook_click);

    }

    // Update is called once per frame
    void Update()
    {

        if (isOpenClicked || isClosedClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;

            if (isOpenClicked)
            {

                if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y > -180)
                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                    isOpenClicked = false;
                    gameObject.SetActive(false);
                    insideBackcover.SetActive(false);
                    openedbook.SetActive(true);
                }
            }
            if (isClosedClicked)
            {
                if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y > 0)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    isClosedClicked = false;
                }
            }
        }
    }

    public void OpenButtonClick()
    {
        isOpenClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 180, 0);

        PlayOpenBookSound();
        FlipPage.Page = 1;
        FlipPage.isClicked = true;
        
    }


     void closebook_click(object sender,EventArgs e)
    {
        gameObject.SetActive(true);
        openedbook.SetActive(false);
        insideBackcover.SetActive(true);

        isClosedClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);

        PlayClosedBookSound();
        
    }
    void PlayOpenBookSound()
    {
        if ((audioSource != null) && (OpenBookSound != null))
        {
            audioSource.PlayOneShot(OpenBookSound);
        }
    }
    void PlayClosedBookSound()
    {
        if ((audioSource != null) && (CloseBookSound != null))
        {
            audioSource.PlayOneShot(CloseBookSound);
        }
    }

}
