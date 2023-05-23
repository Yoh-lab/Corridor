using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atari : MonoBehaviour
{
	public float atari = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
    if(collider.gameObject.tag == "Wall")
	{
	 atari = 1;
	}
   }
   void OnTriggerExit(Collider collider)
   {
    if(collider.gameObject.tag == "Wall")
	{
	 atari = 0;
	}
   }


}
