using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject fireball = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(GameObject dir)
    {
        GameObject new_fireball = Instantiate(fireball, transform.position, transform.rotation) as GameObject;
        //new_fireball.GetComponent<Rigidbody>().AddForce(transform.forward * (10.0f * Time.deltaTime), ForceMode.Impulse);
        new_fireball.GetComponent<FireBall>().shoot_dir = dir;
    }

}
