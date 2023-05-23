using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectA : MonoBehaviour
{
	public float length = 10.0f;
	public float SelectNumber = 0f;
	public float count = 0f; 
	public PlayerA playerA;
	public WallA wallA;
	public GameObject PlayerA;
	public GameObject WallA;
	private GameObject turnA;
	private GameObject turnB;
	public Material red;
	public Material fade;

    void Start()
    {
	turnA = GameObject.Find("TurnA");
	turnB = GameObject.Find("TurnB");
    }

    void OnEnable()
    {
	turnA.GetComponent<Renderer>().material = red;
	turnB.GetComponent<Renderer>().material = fade;
    }

    void Update()
    {
	count = wallA.count;
	if(Input.GetKeyDown(KeyCode.UpArrow)){SelectNumber = 0;}
	if(Input.GetKeyDown(KeyCode.DownArrow)){SelectNumber = 1;}
	switch(SelectNumber)
		{
		 case 0:
			PlayerA.GetComponent<Renderer>().material.color = Color.yellow;
			WallA.GetComponent<Renderer>().material.color = Color.red;
			break;
		 case 1:
			WallA.GetComponent<Renderer>().material.color = Color.yellow;
			PlayerA.GetComponent<Renderer>().material.color = Color.red;
			break;
		}
	if(Input.GetKeyDown(KeyCode.Space)){
					switch(SelectNumber)
						{
						case 0:
							playerA.enabled = true;
							enabled = false;
							break;
						case 1:
							if(count >= 0)
								{
								wallA.enabled = true;
								enabled = false;
								}else{								

								}
							break;
						}
					PlayerA.GetComponent<Renderer>().material.color = Color.red;
					WallA.GetComponent<Renderer>().material.color = Color.red;
					   }
    }


}
