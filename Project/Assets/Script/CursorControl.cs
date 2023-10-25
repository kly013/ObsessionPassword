using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD

=======
        
>>>>>>> origin/main
    }

    // Update is called once per frame
    void Update()
    {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        if (Input.GetKeyDown("2"))
        {
<<<<<<< HEAD

            Cursor.visible = true;
        }

=======
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
>>>>>>> origin/main
        
    }



}
