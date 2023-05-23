using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardB : MonoBehaviour
{
	public float mae = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  mae = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  mae = 0;
	 }
   }

}
