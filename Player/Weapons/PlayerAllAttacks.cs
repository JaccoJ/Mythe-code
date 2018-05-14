using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAllAttacks : MonoBehaviour
{

    public PlayerBoots attackBoots;
    public PlayerHelmet attackHelmet;
    public PlayerSword attackSword;
    public PlayerShield attackShield;

    public bool freezePos = false;

    private bool _attackBoots = false;
    private bool _attackHelmet = false;
    private bool _attackSword = false;
    private bool _attackShield = false;

    public GameObject sword;
    public GameObject shield;

    void Start()
    {
        attackBoots = GetComponent<PlayerBoots>();
        attackHelmet = GetComponent<PlayerHelmet>();
        attackSword = sword.GetComponent<PlayerSword>();
        attackShield = shield.GetComponent<PlayerShield>();

        attackBoots.enabled = false;
        attackHelmet.enabled = false;
        attackSword.enabled = false;
        attackShield.enabled = false;

        sword.SetActive(false);
        shield.SetActive(false);
    }

    void Update()
    {   
        //ATTACK BOOTS
        if (Input.GetKeyDown("3") || Input.GetAxis("rightPad") == 1f)
        {
            _attackBoots = true;
            freezePos = true;

            _attackHelmet = false;
            attackHelmet.enabled = false;
        }
        if (_attackBoots)
        {
            attackBoots.enabled = true;
            if (Input.GetKeyDown("0") || Input.GetAxis("rightPad") == -1f)
            {
                _attackBoots = false;
                attackBoots.enabled = false;
                freezePos = false;
            }
        }

        //ATTACK HELMET
        if (Input.GetKeyDown("4"))
        {
            _attackHelmet = true;
             _attackBoots = false;
            attackBoots.enabled = false;
            freezePos = false;
        }
        if (_attackHelmet)
        {
            attackHelmet.fade();
            if (Input.GetKeyDown("0"))
            {           
                _attackHelmet = false;
                print("fadeback");
            }
        }

        //MAIN ATTACK
        sword.SetActive(false);
        _attackSword = false;
        attackSword.enabled = false;
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("attack"))
        {
            _attackSword = true;
            _attackBoots = false;
            attackBoots.enabled = false;
            freezePos = false;
            _attackHelmet = false;
        }
        if (_attackSword)
        {
            attackSword.enabled = true;
            sword.SetActive(true);
            print("_attackword works");
            if (Input.GetMouseButtonUp(0) || Input.GetButtonUp("attack"))
            {
        
            }
        }

        //SHIELD ATTACK
        if (Input.GetMouseButtonDown(1) || Input.GetAxis("shield") >= 0.5f)
        {
            _attackShield = true;
            _attackSword = false;
            _attackBoots = false;
            attackBoots.enabled = false;
            freezePos = false;
            _attackHelmet = false;
        }
        if (_attackShield)
        {
            attackShield.enabled = true;
            shield.SetActive(true);
            print("_attackshield works");
            if (Input.GetKeyDown("0") || Input.GetAxis("shield") <= 0.5f)
            {
                shield.SetActive(false);
                _attackShield = false;
                attackShield.enabled = false;
                
            }
        }
    }
}