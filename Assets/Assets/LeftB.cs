using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftB : MonoBehaviour
{
	public float hidari = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  hidari = 1;
	 }
   }

   void OnTriggerExit(Collider collider)
   {
	if(collider.gameObject.tag == "PlayerA")
	 {
	  hidari = 0;
	 }
   }

}