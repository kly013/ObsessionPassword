using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static float gameTime = 0;

    public Camera Camera;
    public static Vector3 cameraPos;

    void Start()
    {
        cameraPos = Camera.GetComponent<Transform>().position;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        cameraPos = Camera.transform.position;
    }
}
