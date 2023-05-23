using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB3 : MonoBehaviour
{
	public float length = 10.0f;
	public float DilectionNumber = 0f;
	public SelectA selectA;
	public PlayerB playerB;
	private GameObject B1obj;
	private GameObject B2obj;
	private GameObject B3obj;
	private GameObject B4obj;

    void Start()
    {
	B1obj = GameObject.Find("leftB");
	B2obj = GameObject.Find("rightB");
	B3obj = GameObject.Find("forwardB");
	B4obj = GameObject.Find("buckB");

    }

    void Update()
    {
	if(Input.GetKeyDown(KeyCode.X))
				{
			transform.position -= transform.forward * length;
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;

			DilectionNumber = 0;
			playerB.enabled = true;
			enabled = false;
				}

	Ray ray1 =  new Ray(transform.position, -transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray1, out hit, 5f))
		{
		 B1obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else
				{
				 if(Input.GetKeyDown(KeyCode.LeftArrow))
								{
								 DilectionNumber = 1;
								}
				}
	}
	Ray ray2 =  new Ray(transform.position, transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray2, out hit, 5f))
		{
		 B2obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else
				{
				 if(Input.GetKeyDown(KeyCode.RightArrow))
								{
								 DilectionNumber = 2;
								}
				}
	}
	Ray ray3 =  new Ray(transform.position, transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray3, out hit, 5f))
		{
		 B3obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else
				{
				 if(Input.GetKeyDown(KeyCode.UpArrow))
								{
								 DilectionNumber = 3;
								}
				}
	}
switch(DilectionNumber)
	{
	 case 1:
		B1obj.GetComponent<Renderer>().material.color = Color.yellow;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
	 	break;
	 case 2:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.yellow;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 3:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.yellow;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 4:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.yellow;
		break;
	}
if(DilectionNumber != 0){
	if(Input.GetKeyDown(KeyCode.Space))
					{
					 switch(DilectionNumber)
					 		{
						 	 case 1:
								transform.position -= transform.right * length;
								break;
							 case 2:
								transform.position += transform.right * length;
								break;
							 case 3:
								transform.position += transform.forward * length;
								break;
							}
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
			DilectionNumber = 0;
			selectA.enabled = true;
			enabled = false;
					}
			}    
    }
}