using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    float MouseX, MouseY;
    Transform Head_tr;
    public GameObject Player;
    float health = 100;
    
    public float Sensetive;

    void Start()
    {
        Head_tr = GetComponent<Transform>();
        Cursor.visible = false;
    }

    
    void Update()
    {
       MouseX += Input.GetAxis("Mouse X") * Sensetive;
       //MouseY += Input.GetAxis("Mouse Y") * Sensetive; 

       //MouseY = Mathf.Clamp(MouseY, -90, 90);

       //Head_tr.rotation = Quaternion.Euler(-MouseY, MouseX, 0);
       //Player.transform.rotation = Quaternion.Euler(0, MouseX, 0);
       MouseY += Input.GetAxis("Mouse Y") * Sensetive; 
       
       MouseY = Mathf.Clamp(MouseY, -90, 90);
       Head_tr.rotation = Quaternion.Euler(-MouseY, MouseX, 0);
       Player.transform.rotation = Quaternion.Euler(0, MouseX, 0);

       //if(Input.GetKeyDown("c"))
       //{
            //if(check == 0)
            //{
                //ThirdCam.SetActive(true);
                //.SetActive(false);
               // check = 1;
            //} 
            //else
            //{
               // ThirdCam.SetActive(false);
               // FirstCam.SetActive(true);
               // check = 0;
           // }
       // }
    }
}
