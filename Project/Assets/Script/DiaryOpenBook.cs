using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DiaryOpenBook : MonoBehaviour
{

    public GameObject DiaryCover;
    public GameObject DiaryOpenedbook;
    public GameObject DiaryInsideBookcover;

    public AudioSource audioSource;
    public AudioClip OpenBookSound;
    public AudioClip CloseBookSound;

    private Vector3 RotationVector;

    bool isDiaryOpenClicked;
    bool isDiaryClosedClicked;

    DateTime startTime;
    DateTime endTime;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
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
                    DiaryInsideBookcover.SetActive(false);
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

    public void OpenButtonClick()
    {
        isDiaryOpenClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, 180, 0);

        PlayOpenBookSound();
        DiaryFlipPage.DiaryPage = 1;
        DiaryFlipPage.isDiaryClicked = true;

    }


    public void CloseButtonClick()
    {
        DiaryFlipPage.DiaryPage = 0;
        DiaryCover.SetActive(true);
        DiaryOpenedbook.SetActive(false);
        DiaryInsideBookcover.SetActive(true);

        isDiaryClosedClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, -180, 0);

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
