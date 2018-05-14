using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegasusDrop : MonoBehaviour
{

    //public GameObject shieldDrops;
    // [SerializeField]
    //private float _spawnTime = 5f;
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private bool isDropping = false;

    [SerializeField]
    private Transform spawn;

    [SerializeField]
    private float minTime = 1.0f;

    [SerializeField]
    private float maxTime = 2.0f;

    [SerializeField]
    private GameObject[] pickups;


    void Start()
    {
    }

    IEnumerator Spawn(int index, float seconds)
    {

        yield return new WaitForSeconds(seconds);
        Instantiate(pickups[index], spawn.position, spawn.rotation);


        isDropping = false;
    }

    void Update()
    {
        if ((Vector3.Distance(transform.position, target.transform.position) < 200))
        {
            if (!isDropping)
            {
                isDropping = true;
                int enemyIndex = Random.Range(0, pickups.Length);
                StartCoroutine(Spawn(enemyIndex, Random.Range(minTime, maxTime)));
            }
        }
        else
        {
            isDropping = false;
        }
    }



}