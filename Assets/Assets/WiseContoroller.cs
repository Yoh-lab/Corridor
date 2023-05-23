using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiseContoroller : MonoBehaviour
{
	public float speed = 0.2f;
	public float angleSpeed = 10f;
	public float jumpPower = 300f;
	public float rotateSpeed = 5f;
	public float riverJumpPower = 150f;    
	public Rigidbody rb;
	public Animator jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
	if(Input.GetKey(KeyCode.X) ){
				 if(Input.GetKey(KeyCode.LeftArrow)){
								     transform.RotateAround(this.gameObject.transform.position, -transform.up, Time.deltaTime*2*angleSpeed);
								    }
				 if(Input.GetKey(KeyCode.RightArrow)){
								      transform.RotateAround(this.gameObject.transform.position, transform.up, Time.deltaTime*2*angleSpeed);
								     }
					
				    }else{

	if(Input.GetKey(KeyCode.LeftArrow)){
	transform.Rotate(Vector3.down * Time.deltaTime*20*rotateSpeed, Space.World);	
	}
	if(Input.GetKey(KeyCode.RightArrow)){
	transform.Rotate(Vector3.up * Time.deltaTime*20*rotateSpeed, Space.World);
	}

	if(Input.GetKey(KeyCode.A) ){}else{
	Ray ray2 =  new Ray(transform.position, transform.forward);
	{
		RaycastHit hit2;
		if(Physics.Raycast(ray2, out hit2, 0.9f)){}else
		{
		 if(Input.GetKey(KeyCode.UpArrow)){
		 				   transform.position += transform.forward * speed * Time.deltaTime*5;	
						  }
		}
	}

	Ray ray3 =  new Ray(transform.position, -transform.forward);
	{
		RaycastHit hit3;
		if(Physics.Raycast(ray3, out hit3, 0.9f)){}else
		{
		 if(Input.GetKey(KeyCode.DownArrow)){
		 			             transform.position -= transform.forward * speed * Time.deltaTime*5;	
					   	    }
		}
	}}}

	Ray ray =  new Ray(transform.position, -transform.up);
	{
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, 1f))
		{
		 jump.SetBool("jump", true);
			if(Input.GetKeyDown(KeyCode. Space))
			{
			 rb.AddForce(transform.up * jumpPower);
			}
		 jump.SetBool("jump", false);
		}
	}
	
    }

	void OnTriggerStay(Collider collider)
	{
	
		if(collider.gameObject.tag == "damage")
		{
		 if(Input.GetKeyDown(KeyCode.Space)){
		 				     rb.AddForce(transform.up * riverJumpPower);		   
						     }
		}
	}
	void OnCollisionEnter(Collision collision)
	{
	 	if(collision.gameObject.tag == "Carry")
						{
						 this.transform.parent = collision.transform;

						}
	}
	void OnCollisionExit(Collision collision)
	{
	 	if(collision.gameObject.tag == "Carry")
						{
						 transform.SetParent(null);

						}
	}



}


