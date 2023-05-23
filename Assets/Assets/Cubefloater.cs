using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubefloater : MonoBehaviour
{

	public float changeHeight = 10.0f;
	public Rigidbody rb;

    void Start()
    {
     rb = GetComponent<Rigidbody>();     
    }


    void Update()
    {

     rb.velocity = new Vector3(0, Mathf.Sin(Time.time) * changeHeight, 0);   
    }


}
