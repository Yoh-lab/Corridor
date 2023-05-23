using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStickB : MonoBehaviour
{
	public FloatingJoystick stick;
	public float hori;
	public float vert;
	public float length = 10.0f;
	public float limit = 30f;
	public float arrow;
	public float idou;
	public Vector2 muki;
	public Vector2 origin;
	public float kyori;
	public GameObject obj;
	public GameObject Setting;
	public Collider collider;
	public ChangeDirectionB change;
	public Material yellow;

    void Start()
    {
        stick = GameObject.Find("StickB").GetComponent<FloatingJoystick>();
	hori = stick.Horizontal;
	vert = stick.Vertical;
	origin = new Vector2(0, 0);
    }
    void OnEnable()
    {
	Setting = GameObject.Find("SettingB");
	obj = Instantiate (Setting, Setting.transform.position + new Vector3(0, 4, -40), Setting.transform.rotation);
	collider = obj.GetComponent<BoxCollider>();
	collider.isTrigger =  false;
	change = GameObject.Find("ChangeDirectionB").GetComponent<ChangeDirectionB>();
	change.rotate = 1;
	obj.GetComponent<Renderer>().material = yellow;
    }
    void OnDisable()
    {
	change.rotate = 0;
    }
    void Update()
    {
	hori = stick.Horizontal;
	vert = stick.Vertical;
	muki = stick.Direction;
	kyori = Vector2.Distance(origin, muki);	

        if(vert > hori && vert <= -hori)
	 {
	  arrow = 1;
	 }
        if(vert < hori && vert >= -hori)
	 {
	  arrow = 2;
	 }
        if(vert >= hori && vert > -hori)
	 {
	  arrow = 3;
	 }
        if(vert <= hori && vert < -hori)
	 {
	  arrow = 4;
	 }

	if(kyori == 1)
	 {
	  if(idou == 0)
		{
		 if(obj.transform.position.x >= -limit)
		 	{if(arrow == 1){obj.transform.position -= transform.right * length;}}
		 if(obj.transform.position.x <= limit)
		 	{if(arrow == 2){obj.transform.position += transform.right * length;}}
		 if(obj.transform.position.z <= limit)
		 	{if(arrow == 3){obj.transform.position += transform.forward * length;}}
		 if(obj.transform.position.z >= -limit)
		 	{if(arrow == 4){obj.transform.position -= transform.forward * length;}}
		 idou ++;
		}
	 }
	if(kyori != 1){if(idou == 1){idou --;}}
    }
}
