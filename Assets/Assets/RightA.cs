using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightA : MonoBehaviour
{
	public float migi = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  migi = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  migi = 0;
	 }
   }

}