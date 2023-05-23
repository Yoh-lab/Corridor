using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
	public float changeWidth =10.0f;
	public Rigidbody rb;

    void Start()
    {
     rb = GetComponent<Rigidbody>();     
    }


    void Update()
    {

     rb.velocity = new Vector3(Mathf.Sin(Time.time) * changeWidth, 0, Mathf.Cos(Time.time) * changeWidth);   
    }


}
