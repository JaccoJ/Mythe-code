using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedusaHealth : MonoBehaviour
{

    [SerializeField]
    private Slider MedusaHealthbar;
    private float _maxHealth = 60;
    private float currentlives;

    void Start()
    {
        currentlives = _maxHealth;
    }


    void Update()
    {
        //Sets the Healthbar value to the current lives;
        MedusaHealthbar.value = currentlives;
        DestroyMedusa();
    }

    void DestroyMedusa()
    {
        //if the health is 0 or under it, it will destroy the object
        if (currentlives <= 0)
        {
            Destroy(this.gameObject);
            Application.LoadLevel(0);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        //checks if the enemy is colliding with the sword and if it does 1 hitpoint will go off of it.
        if (other.gameObject.tag == "sword")
        {
            currentlives -= 1f;
        }
    }
}