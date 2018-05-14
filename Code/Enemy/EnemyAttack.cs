using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public Transform enemy;
    // Use this for initialization
    void Start()
    {

    

    }

     void Update()
    {
        Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Player")
        {

        }

    }

}
