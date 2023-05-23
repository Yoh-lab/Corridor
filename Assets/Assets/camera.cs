using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public float angleSpeed = 10f;
	GameObject PlayerObject;
	public Rigidbody rb;
    void Start()
    {
	PlayerObject = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
	transform.position = PlayerObject.transform.position + new Vector3(0, 3, 0);

	if(Input.GetKey(KeyCode.A)){
				    if(Input.GetKey(KeyCode.UpArrow)){
									transform.RotateAround(this.gameObject.transform.position, -transform.right, Time.deltaTime*20*angleSpeed);
								     }
				    if(Input.GetKey(KeyCode.DownArrow)){
									transform.RotateAround(this.gameObject.transform.position, transform.right, Time.deltaTime*20*angleSpeed);
								       }
				   }
    }
}
