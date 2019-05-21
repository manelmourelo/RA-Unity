using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAttacking : MonoBehaviour
{

	public GameObject player = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider other)
	{
        player.GetComponent<Attack>().attacking = true;
	}

}
