using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    private Vector3 direction;
    public GameObject shoot_dir = null;

    // Start is called before the first frame update
    void Start()
    {
        direction = shoot_dir.transform.position - transform.position;
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * (10.0f*Time.deltaTime), Space.World);
    }

    public void RecalculateDirection()
    {
        direction = shoot_dir.transform.position - transform.position;
        direction.Normalize();
    }

}
