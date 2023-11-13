using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ContactFlipPage : MonoBehaviour
{
    Vector3 rotationVector;
    Vector3 startPosition;
    Quaternion startRotation;   
    DateTime startTime;
    DateTime endTime;

    public AudioSource FlipBookAudioSource;
    public AudioClip FlipBookSound;
    static public bool isClicked;
    static public int Page=0;
    bool isPage3;
    bool isPage1;

    public GameObject Page01;
    public GameObject Page02;
    public GameObject Page03;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;

        Page01.SetActive(false);
        Page02.SetActive(false);
        Page03.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);

            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1)
            {
                isClicked = false;
                transform.position = startPosition;
                transform.rotation = startRotation;
            }
        }
        //Debug.Log(Page);

        PagesShow();
    }

    public void RightButtonClick()
    {
        PlaySound();
        isClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 180, 0);
        Page -= 1;
    }
    public void LeftButtonClick()
    {
        PlaySound();
        startTime = DateTime.Now;
        isClicked = true;

        Vector3 newRotation = new Vector3(startRotation.x, 180, startRotation.z);
        transform.rotation = Quaternion.Euler(newRotation);
        rotationVector = new Vector3(0, -180, 0);
        Page += 1;
    }
    public void closeBookBtn_Click()
    {
        Page = 0;
        ContactAppEvent.CloseBookFunction();
    }

    void PagesShow()
    {

        if (Page <= 1 && isPage3==false && (endTime - startTime).TotalMinutes >= 0.5)
        {
            Page = 1;
            Page01.SetActive(true);
            Page02.SetActive(true);

        }

        if (Page >= 2 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            isPage3 = true;
            Page = 2;
            Page03.SetActive(true);

        }

        if(isPage3 ==true && Page == 1 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            
            isPage1 = true;
            isPage3 = false;
            Page = 1;
            Page01.SetActive(true);
        }
        if (isPage1 == true && Page == 1 && (endTime - startTime).TotalMilliseconds >= 1000)
        {
            isPage1 = false;
            isPage3 = false;
            Page = 1;
            Page02.SetActive(true);
        }


        if (Page <= 1 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            Page = 1;
            Page03.SetActive(false);
        }
        if (Page >= 2 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            Page = 2;
            Page01.SetActive(false);

        }
        if (Page >= 2 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            Page = 2;
            Page02.SetActive(false);
        }

    }

    void PlaySound()
    {
        if ((FlipBookAudioSource != null) && (FlipBookSound != null))
        {
            FlipBookAudioSource.PlayOneShot(FlipBookSound);
        }
    }
}
