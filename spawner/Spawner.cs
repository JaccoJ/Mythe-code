using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    bool isSpawning = false;
    public float minTime = 1.0f;
    public float maxTime = 5.0f;
    public GameObject[] enemies;

    // Getter, setter to keep the control over the variables in this script
    /*public float MinTime
    {
        get
        {
            return minTime;
        }
        set
        {
            minTime = value;
        }
    }*/

    int randEnemy;
    IEnumerator SpawnObject(int index, float seconds)
    {
        yield return new WaitForSeconds(seconds);


        isSpawning = false;
    }

    void Update()
    {
        if ((Vector3.Distance(transform.position, target.transform.position) < 30))
        {
            if (!isSpawning)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-20, 10), 5, Random.Range(0, 20));
                int enemyIndex = Random.Range(1, 5);

                isSpawning = true;
                // int spawnPosition = Random.Range(1, 10);
                StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));


                for (int j = 0; j < enemyIndex; j++)
                {
                    GameObject enemy;

                    randEnemy = Random.Range(0, enemies.Length);
                    enemy = Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation) as GameObject;

                }

            }
        }
        else
        {
            isSpawning = false;
        }
    }
}