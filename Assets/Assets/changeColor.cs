using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {        
    }

void OnCollisionEnter(Collision collision){
	if(collision.gameObject.name != "Plane"){
	   collision.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
	}

	}
}
