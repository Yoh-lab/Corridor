using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallB : MonoBehaviour
{
	public float length = 10.0f;
	public float limit = 30f;
	public float count = 9f;
	public GameObject obj;
	public GameObject Setting;
	public SelectA selectA;
	public SelectB selectB;
	public Atari ata;
	public float number;
	public Collider collider;
	public Text text;

    void OnEnable()
    {
	Setting = GameObject.Find("SettingB");
	obj = Instantiate (Setting, Setting.transform.position + new Vector3(0, 4, -10), Setting.transform.rotation);
	collider = obj.GetComponent<BoxCollider>();
	collider.isTrigger =  false;				 
    }


    void Update()
    {
	Text ammoMessage;
	ammoMessage = text.GetComponent<Text>();
	ammoMessage.text = "X" + count ;


ata = obj.GetComponent<Atari>();
number = ata.atari;

if(Input.GetKeyDown(KeyCode.X))
	{
	 Destroy(obj.gameObject);
	 selectB.enabled = true;
	 enabled = false;
	}

if(Input.GetKeyDown(KeyCode.Z))
	{
	 obj.transform.Rotate(Vector3.up * 90) ;
	}

if(obj.transform.position.x >= -limit)
	{if(Input.GetKeyDown(KeyCode.LeftArrow)){obj.transform.position -= transform.right * length;}}     
if(obj.transform.position.x <= limit)
	{if(Input.GetKeyDown(KeyCode.RightArrow)){obj.transform.position += transform.right * length;}}
if(obj.transform.position.z <= limit)
	{if(Input.GetKeyDown(KeyCode.UpArrow)){obj.transform.position += transform.forward * length;}}
if(obj.transform.position.z >= -limit)
	{if(Input.GetKeyDown(KeyCode.DownArrow)){obj.transform.position -= transform.forward * length;}} 


if(Input.GetKeyDown(KeyCode.Space))
			{if(number == 0)
				{
			 	 selectA.enabled = true;
				 collider.isTrigger =  true;
				 count --;
			  	 enabled = false;
				}
			}
    }
}
