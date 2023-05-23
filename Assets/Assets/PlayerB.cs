using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB : MonoBehaviour
{
	public float length = 10.0f;
	public float DilectionNumber = 0f;
	public SelectA selectA;
	public SelectB selectB;

	public ForwardB forwardB;
	public BuckB buckB;
	public LeftB leftB;
	public RightB rightB;
	public PlayerB1 playerB1;
	public PlayerB2 playerB2;
	public PlayerB3 playerB3;
	public PlayerB4 playerB4;
	private GameObject B1obj;
	private GameObject B2obj;
	private GameObject B3obj;
	private GameObject B4obj;

	public float mae;
	public float usiro;
	public float hidari;
	public float migi;

    void Start()
    {
	forwardB = GameObject.Find("forwardB").GetComponent<ForwardB>();
	buckB = GameObject.Find("buckB").GetComponent<BuckB>();
	leftB = GameObject.Find("leftB").GetComponent<LeftB>();
	rightB = GameObject.Find("rightB").GetComponent<RightB>();
	playerB1 = GameObject.Find("PlayerB").GetComponent<PlayerB1>();
	playerB2 = GameObject.Find("PlayerB").GetComponent<PlayerB2>();
	playerB3 = GameObject.Find("PlayerB").GetComponent<PlayerB3>();
	playerB4 = GameObject.Find("PlayerB").GetComponent<PlayerB4>();
	B1obj = GameObject.Find("leftB");
	B2obj = GameObject.Find("rightB");
	B3obj = GameObject.Find("forwardB");
	B4obj = GameObject.Find("buckB");
    }


    void Update()
    {
	if(Input.GetKeyDown(KeyCode.X))
	{
	 DilectionNumber = 0;
	 selectB.enabled = true;
	 enabled = false;
	}	

	mae = forwardB.mae;
	usiro = buckB.usiro;
	hidari = leftB.hidari;
	migi = rightB.migi;

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
								 if(hidari == 1){DilectionNumber = 5;}else{DilectionNumber = 1;}
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
								 if(migi == 1){DilectionNumber = 6;}else{DilectionNumber = 2;}
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
								 if(mae == 1){DilectionNumber = 7;}else{DilectionNumber = 3;}
								}
				}
	}
	Ray ray4 =  new Ray(transform.position, -transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray4, out hit, 5f))
		{
		 B4obj.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0.25f);
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
	 case 5:
		B1obj.GetComponent<Renderer>().material.color = Color.yellow;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
	 	break;
	 case 6:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.yellow;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 7:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.yellow;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
		break;
	 case 8:
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.yellow;
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
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
			DilectionNumber = 0;
			selectA.enabled = true;
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
								playerB1.enabled = true;
								break;
							 case 6:
								transform.position += transform.right * length;
								playerB2.enabled = true;
								break;
							 case 7:
								transform.position += transform.forward * length;
								playerB3.enabled = true;
								break;
							 case 8:
								transform.position -= transform.forward * length;
								playerB4.enabled = true;
								break;
							}
		B1obj.GetComponent<Renderer>().material.color = Color.white;
		B2obj.GetComponent<Renderer>().material.color = Color.white;
		B3obj.GetComponent<Renderer>().material.color = Color.white;
		B4obj.GetComponent<Renderer>().material.color = Color.white;
			DilectionNumber = 0;
			enabled = false;
					}
			}
     }
}
