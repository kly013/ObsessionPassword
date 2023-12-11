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

    static public bool isContactClicked;
    static public int ContactPage = 0;

    bool isContactPage1;
    bool isContactPage3;
    bool isContactPage4;

    public GameObject ContactFirstPageButton;
    public GameObject ContactPage01;
    public GameObject ContactPage02;
    public GameObject ContactPage03;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;

        ContactPage01.SetActive(false);
        ContactPage02.SetActive(false);
        ContactPage03.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (isContactClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);

            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1)
            {
                isContactClicked = false;
                transform.position = startPosition;
                transform.rotation = startRotation;
            }
        }
        //Debug.Log(Page);

        PagesShow();
    }

    public void RightButtonClick()
    {
        isContactClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 180, 0);
        ContactPage -= 1;
        PlaySound();
    }
    public void LeftButtonClick()
    {
        Vector3 newRotation = new Vector3(startRotation.x, 180, startRotation.z);
        transform.rotation = Quaternion.Euler(newRotation);
        isContactClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);
        ContactPage += 1;
        PlaySound();
    }

    void PagesShow()
    {

        if (ContactPage <= 1 && isContactPage3 == false && (endTime - startTime).TotalMinutes >= 0.5)
        {
            ContactFirstPageButton.SetActive(false);
            ContactPage = 1;
            ContactPage01.SetActive(true);
            ContactPage02.SetActive(true);

        }

        if (ContactPage == 2 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            ContactFirstPageButton.SetActive(true);
            isContactPage3 = true;
            ContactPage = 2;
            ContactPage03.SetActive(true);

        }
        if (ContactPage >= 3 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            isContactPage4 = true;
            ContactPage = 3;
            ContactPage03.SetActive(false);
        }

        if (isContactPage3 == true && ContactPage == 1 && (endTime - startTime).TotalSeconds >= 0.09)
        {

            isContactPage1 = true;
            isContactPage3 = false;
            ContactPage = 1;
            ContactPage01.SetActive(true);
        }
        if (isContactPage1 == true && ContactPage == 1 && (endTime - startTime).TotalMilliseconds >= 1000)
        {
            ContactFirstPageButton.SetActive(false);
            isContactPage1 = false;
            isContactPage3 = false;
            ContactPage = 1;
            ContactPage02.SetActive(true);
        }

        if (isContactPage4 == true && ContactPage == 2 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            isContactPage1 = false;
            isContactPage3 = false;
            isContactPage4 = false;
            ContactPage = 2;
            ContactPage03.SetActive(true);
        }


        if (ContactPage <= 1 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            ContactPage = 1;
            ContactPage03.SetActive(false);
        }
        if (ContactPage == 2 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            ContactPage = 2;
            ContactPage01.SetActive(false);

        }
        if (ContactPage == 2 && (endTime - startTime).TotalSeconds >= 0.09)
        {
            ContactPage = 2;
            ContactPage02.SetActive(false);
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
