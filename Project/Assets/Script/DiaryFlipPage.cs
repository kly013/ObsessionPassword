using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DiaryFlipPage : MonoBehaviour
{
    Vector3 rotationVector;
    Vector3 startPosition;
    Quaternion startRotation;   
    DateTime startTime;
    DateTime endTime;

    public AudioSource FlipBookAudioSource;
    public AudioClip FlipBookSound;

    static public bool isDiaryClicked;
    static public int DiaryPage=0;

    bool isDiaryPage1;
    bool isDiaryPage2;

    public GameObject DiaryFirstPageButton;
    public GameObject DiaryPage01;
    public GameObject DiaryPage02;
    public GameObject DiaryPage03;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        startPosition = transform.position;

        DiaryPage01.SetActive(false);
        DiaryPage02.SetActive(false);
        DiaryPage03.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (isDiaryClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);

            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= 1)
            {
                isDiaryClicked = false;
                transform.position = startPosition;
                transform.rotation = startRotation;
            }
        }

        //Debug.Log((endTime - startTime).TotalMinutes);
        PagesShow();
    }

    public void RightButtonClick()
    {
        isDiaryClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 180, 0);
        DiaryPage += 1;
        PlaySound();
    }
    public void LeftButtonClick()
    {
        Vector3 newRotation = new Vector3(startRotation.x, 180, startRotation.z);
        transform.rotation = Quaternion.Euler(newRotation);
        isDiaryClicked = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);
        DiaryPage -= 1;
        PlaySound();
    }

    void PagesShow()
    {

        if (DiaryPage <= 1 && (endTime - startTime).TotalMinutes >= 0.002)
        {
            DiaryFirstPageButton.SetActive(false);
            isDiaryPage1 = true;
            DiaryPage = 1;
            DiaryPage01.SetActive(true);
        }

        if (isDiaryPage1 == true && DiaryPage == 2 && (endTime - startTime).TotalMinutes >= 0.002)
        {
            DiaryFirstPageButton.SetActive(true);
            isDiaryPage1 = false;
            isDiaryPage2 = true;
            DiaryPage02.SetActive(true);

        }
        else if (DiaryPage == 2 && (endTime - startTime).TotalMilliseconds >= 900)
        {
            isDiaryPage2 = true;
            DiaryPage02.SetActive(true);
        }

        if (isDiaryPage2 == true && DiaryPage == 3 && (endTime - startTime).TotalMinutes >= 0.002)
        {
            isDiaryPage2 = false;
            DiaryPage03.SetActive(true);
        }
        else if (DiaryPage == 3 && (endTime - startTime).TotalMilliseconds >= 900)
        {
            DiaryPage03.SetActive(true);
        }


        if (DiaryPage >= 4 && (endTime - startTime).TotalMinutes >= 0.002)
        {
            DiaryPage = 4;
            DiaryPage03.SetActive(false);
        }


        if (DiaryPage <= 1 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            DiaryPage = 1;
            DiaryPage02.SetActive(false);
            DiaryPage03.SetActive(false);
        }
        if (DiaryPage == 2 && (endTime - startTime).TotalSeconds >= 0.9)
        {
            DiaryPage = 2;
            DiaryPage01.SetActive(false);
            DiaryPage03.SetActive(false);
        }
        if (DiaryPage == 3 && (endTime - startTime).TotalSeconds >= 0.1)
        {
            DiaryPage = 3;
            DiaryPage01.SetActive(false);
            DiaryPage02.SetActive(false);
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
