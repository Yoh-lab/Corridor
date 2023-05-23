using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftA : MonoBehaviour
{
	public float hidari = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  hidari = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerB")
	 {
	  hidari = 0;
	 }
   }

}