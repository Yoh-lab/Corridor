using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtariPlayerA : MonoBehaviour
{
	public float atari = 0f;
    void Start()
    {
        
    }

   void OnTriggerStay(Collider collider)
   {
    if(collider.gameObject.tag == "PlayerB")
	{
	 atari = 1;
	}
   }
   void OnTriggerExit(Collider collider)
   {
    if(collider.gameObject.tag == "PlayerB")
	{
	 atari = 0;
	}
   }


}
