using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent nav;
    public Transform Player_tr;
    float Health = 10; 
    static float PlayerWin = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(Player_tr.position);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Health = Health - 1;
            if(Health == 0)
            {
                Destroy(gameObject);
                PlayerWin = PlayerWin - 1;
                print(PlayerWin);
                if(PlayerWin==0)
                {
                    SceneManager.LoadScene("SampleScene");   
                }
            }
        }
    }
}
