using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public GameObject[] cameraPos;
    Vector3 playerPos;
    BackToOrig backToOrig;

    public static bool isChange;

    public void CameraChange(string name)
    {
        playerPos = player.transform.position;
        
        isChange = true;

        switch (name)
        {
            case "Shelf002":
                player.transform.position = cameraPos[0].transform.position;
                break;
            case "Table004":
                player.transform.position = cameraPos[1].transform.position;
                break;
            case "Sink":
                player.transform.position = cameraPos[2].transform.position;
                break;
            case "Table002":
                player.transform.position = cameraPos[3].transform.position;
                break;
            case "Refrigerator001":
                player.transform.position = cameraPos[4].transform.position;
                break;
            case "Refrigerator002":
                player.transform.position = cameraPos[5].transform.position;
                break;
            case "Refrigerator003":
                player.transform.position = cameraPos[6].transform.position;
                break;
            default:
                isChange = false;
                break;
        }

        if(isChange)
        {
            player.transform.rotation = new Quaternion(0, 0, 0, 0);
            LevelText01.isTalking = true;
            backToOrig = GetComponent<BackToOrig>();
            backToOrig.enabled = true;
            backToOrig.ToOrig(player, playerPos);
        }
    }
}
