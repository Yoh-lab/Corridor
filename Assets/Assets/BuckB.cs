using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckB : MonoBehaviour
{
	public float usiro = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  usiro = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  usiro = 0;
	 }
   }

}
