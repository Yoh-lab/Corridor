using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
	public float count = 0f;
	public GameObject atari;
    void Start()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
	if(collider.gameObject.tag == "Switch")
	 {
	  atari = collider.gameObject;
	  count = 1;
	 }
	if(collider.gameObject.tag == "GoalW")
	 {
	  atari = collider.gameObject;
	  count = 2;
	 }
	if(collider.gameObject.tag == "GoalB")
	 {
	  atari = collider.gameObject;
	  count = 3;
	 }

    }
    void OnTriggerExit(Collider collider)
    {
	if(collider.gameObject.tag == "Switch")
	 {
	  atari = null;
	  count = 0;
	 }
    }

}
