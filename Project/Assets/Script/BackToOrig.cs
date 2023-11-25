using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToOrig : MonoBehaviour
{
    GameObject Player;
    Vector3 PlayerPos;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Player.transform.position = PlayerPos;
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
