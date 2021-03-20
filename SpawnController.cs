using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Bullet;
    GameObject Clone;
    Rigidbody Clone_rb;
    int score = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Clone = Instantiate(Bullet, transform.position, Quaternion.Euler(90 + transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0));
            Clone_rb = Clone.GetComponent<Rigidbody>();
            Clone_rb.AddForce(transform.forward * 200);
        }
    }
}
