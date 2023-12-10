using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenBook : MonoBehaviour
{
    public GameObject DiaryCover;
    public GameObject ContactCover;
    public GameObject DiaryOpenedbook;
    public GameObject DiaryInsideBackcover;
    public GameObject ContactOpenedbook;
    public GameObject ContactInsideBackcover;

    public AudioSource audioSource;
    public AudioClip OpenBookSound;
    public AudioClip CloseBookSound;
    private Vector3 RotationVector;
    bool isDiaryOpenClicked;
    bool isDiaryClosedClicked;

    bool isContactOpenClicked;
    bool isContactClosedClicked;
    DateTime startTime;
    DateTime endTime;

    public static bool isDiary = false;
    public static bool isContactBook = false;

    // Update is called once per frame
    void Update()
    {
        if (isDiary)
        {
            if (isDiaryOpenClicked || isDiaryClosedClicked)
            {
                transform.Rotate(RotationVector * Time.deltaTime);
                endTime = DateTime.Now;

                if (isDiaryOpenClicked)
                {

                    if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y > -180)
                    {
                        transform.eulerAngles = new Vector3(0, 180, 0);
                        isDiaryOpenClicked = false;
                        DiaryCover.SetActive(false);
                        DiaryInsideBackcover.SetActive(false);
                        DiaryOpenedbook.SetActive(true);
                    }
                }
                if (isDiaryClosedClicked)
                {
                    if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y > 0)
                    {
                        transform.eulerAngles = new Vector3(0, 0, 0);
                        isDiaryClosedClicked = false;
                    }
                }
            }
        }

        if (isContactBook)
        {
            if (isContactOpenClicked || isContactClosedClicked)
            {
                transform.Rotate(RotationVector * Time.deltaTime);
                endTime = DateTime.Now;

                if (isContactOpenClicked)
                {

                    if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y < 180)
                    {
                        transform.eulerAngles = new Vector3(0, -180, 0);
                        isContactOpenClicked = false;
                        ContactCover.SetActive(false);
                        ContactInsideBackcover.SetActive(false);
                        ContactOpenedbook.SetActive(true);
                    }
                }
                if (isContactClosedClicked)
                {
                    if ((endTime - startTime).TotalSeconds >= 1 && transform.eulerAngles.y > 0)
                    {
                        transform.eulerAngles = new Vector3(0, 0, 0);
                        isContactClosedClicked = false;
                    }
                }
            }
        }
    }

    public void DiaryOpenButtonClick()
    {
        isDiaryOpenClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, 180, 0);

        PlayOpenBookSound();
        FlipPage.DiaryPage = 1;
        FlipPage.isDiaryClicked = true;

    }
    public void ContactOpenButtonClick()
    {
        isContactOpenClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, -180, 0);

        PlayOpenBookSound();
        FlipPage.ContactPage = 1;
        FlipPage.isContactClicked = true;
    }


    public void DiaryCloseButtonClick()
    {
        isDiary = false;
        FlipPage.DiaryPage = 0;
        DiaryCover.SetActive(true);
        DiaryOpenedbook.SetActive(false);
        DiaryInsideBackcover.SetActive(true);

        isDiaryClosedClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, -180, 0);

        PlayClosedBookSound();
    }

    public void ContactCloseButtonClick()
    {
        isContactBook = false;
        FlipPage.ContactPage = 0;
        ContactCover.SetActive(true);
        ContactOpenedbook.SetActive(false);
        ContactInsideBackcover.SetActive(true);

        isContactClosedClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, 180, 0);

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
