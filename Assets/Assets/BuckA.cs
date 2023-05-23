using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckA : MonoBehaviour
{
	public float usiro = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  usiro = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  usiro = 0;
	 }
   }

}
