using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public LayerMask enemies;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, enemies) || Input.GetKeyDown(KeyCode.Return))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            gameObject.GetComponent<Animator>().SetBool("Attack", true);
            timer = 0.0f;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }

        timer += Time.deltaTime;

        if (timer >= 1.0f)
        {
            gameObject.GetComponent<Animator>().SetBool("Attack", false);
        }

    }
}
