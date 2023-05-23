using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cureItem : MonoBehaviour
{

	public float rotateSpeed =10.0f;
    void Start()
    {
        
    }

    void Update()
    {
     transform.Rotate(Vector3.down * Time.deltaTime*20*rotateSpeed, Space.World);   
    }

	void OnTriggerEnter(Collider collider)
					  {
					   if(collider.gameObject.tag == "Player" | collider.gameObject.tag == "Bullet")
										{
										 Destroy(this.gameObject, 0.01f);
										}
				 	  }

}
