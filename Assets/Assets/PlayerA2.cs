using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA2 : MonoBehaviour
{
	public float length = 10.0f;
	public float DilectionNumber = 0f;
	public SelectB selectB;
	public PlayerA playerA;
	private GameObject A1obj;
	private GameObject A2obj;
	private GameObject A3obj;
	private GameObject A4obj;

    void Start()
    {
	A1obj = GameObject.Find("leftA");
	A2obj = GameObject.Find("rightA");
	A3obj = GameObject.Find("forwardA");
	A4obj = GameObject.Find("buckA");
    }

    void Update()
    {
	if(Input.GetKeyDown(KeyCode.X))
				{
			transform.position -= transform.right * length;
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;

			DilectionNumber = 0;
			playerA.enabled = true;
			enabled = false;
				}

	Ray ray2 =  new Ray(transform.position, transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray2, out hit, 5f))
		{
		 A2obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
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
		 A3obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else

				{
				 if(Input.GetKeyDown(KeyCode.UpArrow))
								{
								 DilectionNumber = 3;
								}
				}
	}
	Ray ray4 =  new Ray(transform.position, -transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray4, out hit, 5f))
		{
		 A4obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else

				{
				 if(Input.GetKeyDown(KeyCode.DownArrow))
								{
								 DilectionNumber = 4;
								}
				}
	}
switch(DilectionNumber)
	{
	 case 1:
		A1obj.GetComponent<Renderer>().material.color = Color.yellow;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
	 	break;
	 case 2:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.yellow;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 3:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.yellow;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 4:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.yellow;
		break;
	}
if(DilectionNumber != 0){
	if(Input.GetKeyDown(KeyCode.Space))
					{
					 switch(DilectionNumber)
					 		{
							 case 2:
								transform.position += transform.right * length;
								break;
							 case 3:
								transform.position += transform.forward * length;
								break;
							 case 4:
								transform.position -= transform.forward * length;
								break;
							}
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
			DilectionNumber = 0;
			selectB.enabled = true;
			enabled = false;
					}
			}    
    }
}