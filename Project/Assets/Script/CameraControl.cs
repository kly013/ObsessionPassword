using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //public GameObject player;
    //public GameObject[] cameraPos;
    //Transform playerTra;
    //BackToOrig backToOrig;
    //MeshCollider meshCollider;

    //public static bool isChange;

    //public void CameraChange(string name)
    //{
    //    playerTra = player.transform;
    //    meshCollider = RayScript.hit.collider.GetComponent<MeshCollider>();

    //    isChange = true;

    //    switch (name)
    //    {
    //        case "Shelf002":
    //            player.transform.position = cameraPos[0].transform.position;
    //            player.transform.rotation = cameraPos[0].transform.rotation;
    //            break;
    //        case "Table004":
    //            player.transform.position = cameraPos[1].transform.position;
    //            player.transform.rotation = cameraPos[1].transform.rotation;
    //            break;
    //        case "Sink":
    //            player.transform.position = cameraPos[2].transform.position;
    //            player.transform.rotation = cameraPos[2].transform.rotation;
    //            break;
    //        case "Table002":
    //            player.transform.position = cameraPos[3].transform.position;
    //            player.transform.rotation = cameraPos[3].transform.rotation;
    //            break;
    //        case "Refrigerator001":
    //            player.transform.position = cameraPos[4].transform.position;
    //            player.transform.rotation = cameraPos[4].transform.rotation;
    //            break;
    //        case "Refrigerator002":
    //            player.transform.position = cameraPos[5].transform.position;
    //            player.transform.rotation = cameraPos[5].transform.rotation;
    //            break;
    //        case "Refrigerator003":
    //            player.transform.position = cameraPos[6].transform.position;
    //            player.transform.rotation = cameraPos[6].transform.rotation;
    //            break;
    //        default:
    //            isChange = false;
    //            break;
    //    }

    //    if(isChange)
    //    {
    //        backToOrig = GetComponent<BackToOrig>();
    //        backToOrig.enabled = true;
            
    //        meshCollider.enabled = false;

    //        backToOrig.ToOrig(player, playerTra, meshCollider);

    //        LevelController.isChangeCamera = true;
    //    }
    //}
}
