using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorA : MonoBehaviour
{
	public float length = 10.0f;
	public float SelectNumber = 0f;
	public float DilectionNumber = 0f; 
	public GameObject obj;
	public GameObject wall;
	public GameObject Setting;	


    void Start()
    {

    }

   void Update()
   {
	if(Input.GetKeyDown(KeyCode.LeftArrow))
				{
				 DilectionNumber = 1;
				}
	if(Input.GetKeyDown(KeyCode.RightArrow))
				{
				 DilectionNumber = 2;
				}
	if(Input.GetKeyDown(KeyCode.UpArrow))
				{
				 DilectionNumber = 3;
				}
	if(Input.GetKeyDown(KeyCode.DownArrow))
				{
				 DilectionNumber = 4;
				}

	if(Input.GetKeyDown(KeyCode.Space))
				{
				 switch(SelectNumber)
					{
					 case 0:
						ObjSelect();
						break;
					 case 1:
						switch(DilectionNumber)
						   {
						case 3:
							PlayerA();
							break;
						case 4:
							WallA();
							break;
						   }break;
					}
				SelectNumber += 1;
				}
   }

  public void ObjSelect(){
			switch(DilectionNumber)
			{
			case 3:
				obj = GameObject.Find("PlayerA");
				break;
			case 4:
				Setting = GameObject.Find("Setting");
				obj = Instantiate (Setting, Setting.transform.position, Setting.transform.rotation);
				break;
			}
			  }

   public void PlayerA()
     {
			switch(DilectionNumber)
			{
			case 1:
				Ray ray1 =  new Ray(obj.transform.position, -transform.right);
						{
	 					 RaycastHit hit;
	 					 if(Physics.Raycast(ray1, out hit, 5f)){}else
								{
								 obj.transform.position -= transform.right * length;
								}
						}
				break;
			case 2:
				Ray ray2 =  new Ray(obj.transform.position, transform.right);
						{
	 					 RaycastHit hit;
	 					 if(Physics.Raycast(ray2, out hit, 5f)){}else
								{
								 obj.transform.position += transform.right * length;
								}
						}
				break;
			case 3:
				Ray ray3 =  new Ray(obj.transform.position, transform.forward);
						{
	 					 RaycastHit hit;
	 					 if(Physics.Raycast(ray3, out hit, 5f)){}else
								{
								 obj.transform.position += transform.forward * length;
								}
						}
				break;
			case 4:
				Ray ray4 =  new Ray(obj.transform.position, -transform.forward);
						{
	 					 RaycastHit hit;
	 					 if(Physics.Raycast(ray4, out hit, 5f)){}else
								{
								 obj.transform.position -= transform.forward * length;
								}
						}
				break;
			}

	}

   public void WallA(){}
}
