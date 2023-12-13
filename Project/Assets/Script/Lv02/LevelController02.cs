using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController02 : MonoBehaviour
{
    public static float gameTimer = 0;
    public static int levelnum = 1;

    public static bool isTakeLook;

    public static string selectName;
    public static string clickName;

    public static List<GameObject> toolsList = new List<GameObject>();

    public static bool isPower;

    public static bool isLv02Finish;

    public GameObject player;
    public GameObject ghost;

    Animator animator;

    void Start()
    {
        gameTimer = 0;
    }
    
    void Update()
    {
        gameTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                animator = ghost.GetComponent<Animator>();
                animator.enabled = false;
                ghost.transform.position = player.transform.position + new Vector3(2, 0, 2);
            }
        }
    }
}
