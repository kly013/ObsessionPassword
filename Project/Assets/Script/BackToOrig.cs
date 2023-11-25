using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToOrig : MonoBehaviour
{
    GameObject Player;
    Vector3 PlayerPos;
    public GameObject r1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Player.transform.position = PlayerPos;
            if(CameraControl.isR1)
            {
                r1.GetComponent<MeshCollider>().enabled = true;
            }
            LevelText01.isTalking = false;
            GetComponent<BackToOrig>().enabled = false;
        }
    }

    public void ToOrig(GameObject player, Vector3 playerPos)
    {
        Player = player;
        PlayerPos = playerPos;
    }
}
