using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
	public float length = 10.0f;
	public float DilectionNumber = 0f;
	public SelectB selectB;
	public SelectA selectA;

	public ForwardA forwardA;
	public BuckA buckA;
	public LeftA leftA;
	public RightA rightA;
	public PlayerA1 playerA1;
	public PlayerA2 playerA2;
	public PlayerA3 playerA3;
	public PlayerA4 playerA4;
	private GameObject A1obj;
	private GameObject A2obj;
	private GameObject A3obj;
	private GameObject A4obj;

	public float mae;
	public float usiro;
	public float hidari;
	public float migi;

    void Start()
    {
	forwardA = GameObject.Find("forwardA").GetComponent<ForwardA>();
	buckA = GameObject.Find("buckA").GetComponent<BuckA>();
	leftA = GameObject.Find("leftA").GetComponent<LeftA>();
	rightA = GameObject.Find("rightA").GetComponent<RightA>();
	playerA1 = GameObject.Find("PlayerA").GetComponent<PlayerA1>();
	playerA2 = GameObject.Find("PlayerA").GetComponent<PlayerA2>();
	playerA3 = GameObject.Find("PlayerA").GetComponent<PlayerA3>();
	playerA4 = GameObject.Find("PlayerA").GetComponent<PlayerA4>();  
	A1obj = GameObject.Find("leftA");
	A2obj = GameObject.Find("rightA");
	A3obj = GameObject.Find("forwardA");
	A4obj = GameObject.Find("buckA");

   }


    void Update()
    {
	if(Input.GetKeyDown(KeyCode.X))
	{
	 DilectionNumber = 0;
	 selectA.enabled = true;
	 enabled = false;
	}	

	mae = forwardA.mae;
	usiro = buckA.usiro;
	hidari = leftA.hidari;
	migi = rightA.migi;

	Ray ray1 =  new Ray(transform.position, -transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray1, out hit, 5f))
		{
		 A1obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
		}else
				{
				 if(Input.GetKeyDown(KeyCode.LeftArrow))
								{
								 if(hidari == 1){DilectionNumber = 5;}else{DilectionNumber = 1;}
								}
				}
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
								 if(migi == 1){DilectionNumber = 6;}else{DilectionNumber = 2;}
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
								 if(mae == 1){DilectionNumber = 7;}else{DilectionNumber = 3;}
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
								 if(usiro == 1){DilectionNumber = 8;}else{DilectionNumber = 4;}
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
	 case 5:
		A1obj.GetComponent<Renderer>().material.color = Color.yellow;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
	 	break;
	 case 6:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.yellow;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 7:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.yellow;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 8:
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.yellow;
		break;
	}

if(DilectionNumber != 0 &&
   DilectionNumber != 5 &&
   DilectionNumber != 6 &&
   DilectionNumber != 7 &&
   DilectionNumber != 8){
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
if(DilectionNumber != 0){
	if(Input.GetKeyDown(KeyCode.Space))
					{
					 switch(DilectionNumber)
					 		{
						 	 case 5:
								transform.position -= transform.right * length;
								playerA1.enabled = true;
								break;
							 case 6:
								transform.position += transform.right * length;
								playerA2.enabled = true;
								break;
							 case 7:
								transform.position += transform.forward * length;
								playerA3.enabled = true;
								break;
							 case 8:
								transform.position -= transform.forward * length;
								playerA4.enabled = true;
								break;
							}
		A1obj.GetComponent<Renderer>().material.color = Color.white;
		A2obj.GetComponent<Renderer>().material.color = Color.white;
		A3obj.GetComponent<Renderer>().material.color = Color.white;
		A4obj.GetComponent<Renderer>().material.color = Color.white;
			DilectionNumber = 0;
			enabled = false;
					}
			}
     }
}
