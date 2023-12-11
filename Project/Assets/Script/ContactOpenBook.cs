using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ContactOpenBook : MonoBehaviour
{
    public GameObject ContactCover;
    public GameObject ContactOpenedbook;
    public GameObject ContactInsideBookcover;

    public AudioSource audioSource;
    public AudioClip OpenBookSound;
    public AudioClip CloseBookSound;

    private Vector3 RotationVector;

    bool isContactOpenClicked;
    bool isContactClosedClicked;

    DateTime startTime;
    DateTime endTime;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
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
                    ContactInsideBookcover.SetActive(false);
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

    public void OpenButtonClick()
    {
        isContactOpenClicked = true;
        startTime = DateTime.Now;
        RotationVector = new Vector3(0, -180, 0);


        PlayOpenBookSound();
        ContactFlipPage.ContactPage = 1;
        ContactFlipPage.isContactClicked = true;

    }


    public void CloseButtonClick()
    {
        ContactFlipPage.ContactPage = 0;
        ContactCover.SetActive(true);
        ContactOpenedbook.SetActive(false);
        ContactInsideBookcover.SetActive(true);

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
