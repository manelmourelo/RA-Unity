﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private float timer = 0.0f;
    private bool has_attacked = false;

    public bool attacking = false;
    public bool under_attack = false;

    public GameObject other_player = null;
    public GameObject fireball = null;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((attacking == true && has_attacked == false) && under_attack == false || Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.GetComponent<Animator>().SetBool("Attack", true);
            GameObject new_fireball = Instantiate(fireball, transform.position, transform.rotation) as GameObject;
            new_fireball.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10.0f);
            timer = 0.0f;
            has_attacked = true;
            attacking = false;
        }

        timer += Time.deltaTime;

        if (timer >= 1.0f)
        {
            gameObject.GetComponent<Animator>().SetBool("Attack", false);
        }

    }
    
    //void OnTriggerEnter(Collider other)
    //{
    //    attacking = true;
    //    other_player.GetComponent<Attack>().under_attack = true;
    //}

}
