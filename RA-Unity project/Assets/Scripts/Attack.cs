﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private float timer = 0.0f;
    private bool has_attacked = false;

    public bool attacking = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((attacking == true && has_attacked == false) || Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.GetComponent<Animator>().SetBool("Attack", true);
            timer = 0.0f;
            has_attacked = true;
        }

        timer += Time.deltaTime;

        if (timer >= 1.0f)
        {
            gameObject.GetComponent<Animator>().SetBool("Attack", false);
        }

    }
    
    void OnTriggerEnter(Collider other)
    {
        attacking = true;
    }

}
