using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
	if(Input.GetKey(KeyCode.LeftArrow)){
	transform.Translate(new Vector3(-5f, 0, 0));	
	}
	if(Input.GetKey(KeyCode.RightArrow)){
	transform.Translate(new Vector3(5f, 0, 0));
	}	
	if(Input.GetKey(KeyCode.UpArrow)){
	transform.Translate(new Vector3(0, 0, 5f));	
	}
	if(Input.GetKey(KeyCode.DownArrow)){
	transform.Translate(new Vector3(0, 0, -5f));	
	}

    }

}
