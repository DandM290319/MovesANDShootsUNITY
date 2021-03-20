using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
       // if(col.gameObject.tag == "player")
       // {
           // health = health - 25;
          // print(health);
      //  }
      Destroy(gameObject);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Destroy(gameObject);
    }
}
