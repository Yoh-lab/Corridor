using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectB : MonoBehaviour
{
	public float length = 10.0f;
	public float SelectNumber = 0f;
	public float count = 0f; 
	public PlayerB playerB;
	public WallB wallB;
	public GameObject PlayerB;
	public GameObject WallB;
	private GameObject turnA;
	private GameObject turnB;
	public Material blue;
	public Material fade;

    void Start()
    {
	turnA = GameObject.Find("TurnA");
	turnB = GameObject.Find("TurnB");
	turnA.GetComponent<Renderer>().material = fade;
	turnB.GetComponent<Renderer>().material = blue;
    }

    void OnEnable()
    {
	turnA.GetComponent<Renderer>().material = fade;
	turnB.GetComponent<Renderer>().material = blue;
    }

    void Update()
    {
	count = wallB.count;
	if(Input.GetKeyDown(KeyCode.UpArrow)){SelectNumber = 1;}
	if(Input.GetKeyDown(KeyCode.DownArrow)){SelectNumber = 0;}
	switch(SelectNumber)
		{
		 case 0:
			PlayerB.GetComponent<Renderer>().material.color = Color.yellow;
			WallB.GetComponent<Renderer>().material.color = Color.blue;
			break;
		 case 1:
			WallB.GetComponent<Renderer>().material.color = Color.yellow;
			PlayerB.GetComponent<Renderer>().material.color = Color.blue;
			break;
		}
	if(Input.GetKeyDown(KeyCode.Space)){
					switch(SelectNumber)
						{
						case 0:
							playerB.enabled = true;
							enabled = false;
							break;
						case 1:
							if(count >= 0)
								{
								wallB.enabled = true;
								enabled = false;
								}else{
								
								}
							break;
						}
					PlayerB.GetComponent<Renderer>().material.color = Color.blue;
					WallB.GetComponent<Renderer>().material.color = Color.blue;
					   }
    }


}
