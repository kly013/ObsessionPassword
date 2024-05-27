using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksSpaceBack : MonoBehaviour
{
    static public bool goBack = false;

    void Start()
    {
        goBack = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.Find("Player").transform.position == new Vector3(1.398f, 5.729f, 20.329f))
        {
            goBack = true;

        }
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.Find("Player").transform.position == new Vector3(5.9f, 5.85f, 19.64f))
        {
            goBack = true;

        }
    }
}
