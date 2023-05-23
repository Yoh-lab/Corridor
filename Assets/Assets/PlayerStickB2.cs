﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStickB2 : MonoBehaviour
{
	public FloatingJoystick stick;
	public float hori;
	public float vert;
	public float muki;
	public GameObject subB;
	public GameObject playerB;
	public GameObject playerA;
	public float direct = 0f;
	public Material red;
	public Material blue;
	public Material green;
	public Material fade;
	public Material yellow;
	public GameObject wallB;
	public GameObject stockB;
	public GameObject turnA;
	public GameObject turnB;
	public float tonari;
	public AtariPlayerB mae;
	public AtariPlayerB usiro;
	public AtariPlayerB hidari;
	public AtariPlayerB migi;
	public PlayerStickB playerStickB;
	public  PlayerButtonA playerButtonA;
	public  PlayerButtonB playerButtonB;
	public  StockButtonA stockButtonA;
	public  StockButtonB stockButtonB;


    void Start()
    {
        stick = GameObject.Find("PlayerStickB").GetComponent<FloatingJoystick>();
	hori = stick.Horizontal;
	vert = stick.Vertical;
	subB = GameObject.Find("SubB");
	playerB = GameObject.Find("PlayerB");
	playerA = GameObject.Find("PlayerA");
	stockB = GameObject.Find("StockB");
	wallB = GameObject.Find("WallB");
	turnA = GameObject.Find("TurnA");
	turnB = GameObject.Find("TurnB");
	mae = GameObject.Find("mae").GetComponent<AtariPlayerB>();
	usiro = GameObject.Find("usiro").GetComponent<AtariPlayerB>();
	hidari = GameObject.Find("hidari").GetComponent<AtariPlayerB>();
	migi = GameObject.Find("migi").GetComponent<AtariPlayerB>();
	playerStickB =GameObject.Find("StickB").GetComponent<PlayerStickB>();
        playerButtonA = GameObject.Find("TurnA").GetComponent<PlayerButtonA>();
        playerButtonB = GameObject.Find("TurnB").GetComponent<PlayerButtonB>();
        stockButtonA = GameObject.Find("StockA").GetComponent<StockButtonA>();
        stockButtonB = GameObject.Find("StockB").GetComponent<StockButtonB>();
    }

    void OnEnable()
    {
    }

    void OnDisable()
    {
	subB.transform.position = playerB.transform.position;
	playerStickB.tonari = 0;
    }
    public void UpClicked()
    {
	if(direct == 1 && muki != 0)
	{
	 playerB.GetComponent<Renderer>().material = blue;
	 wallB.GetComponent<Renderer>().material = blue;
	 stockB.GetComponent<Renderer>().material = green;
	 turnB.GetComponent<Renderer>().material = fade;
	 turnA.GetComponent<Renderer>().material = red;
	 playerA.GetComponent<Renderer>().material = red;
	 muki = 0;
	 direct = 0;
	 stockButtonA.selectA  ++; 
	 playerButtonA.selectA ++;
	 stockButtonB.selectB  --;
	 enabled = false;
	}
    }

    void Update()
    {
	direct = 1;
	tonari = playerStickB.tonari;
	hori = stick.Horizontal;
	vert = stick.Vertical;

        if(vert > hori && vert <= -hori)
	 {muki = 1;}
        if(vert < hori && vert >= -hori)
	 {muki = 2;}
        if(vert >= hori && vert > -hori)
	 {muki = 3;}
        if(vert <= hori && vert < -hori)
	 {muki = 4;}

	Ray ray1 =  new Ray(subB.transform.position, -transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray1, out hit, 5f))
		{}else{
			if(muki == 1)
				{
				 if(tonari != 2)
					{
					 playerB.transform.position = subB.transform.position + new Vector3(-10, 0, 0);
					}
				}
		     }
	}
	Ray ray2 =  new Ray(subB.transform.position, transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray2, out hit, 5f))
		{}else{
			if(muki == 2)
				 if(tonari != 1)
					{
					 playerB.transform.position = subB.transform.position + new Vector3(10, 0, 0);
					}
		     }
	}
	Ray ray3 =  new Ray(subB.transform.position, transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray3, out hit, 5f))
		{}else{
			if(muki == 3)
				{
				 if(tonari != 4)
					{
					 playerB.transform.position = subB.transform.position + new Vector3(0, 0, 10);
					}
				}
		     }
	}
	Ray ray4 =  new Ray(subB.transform.position, -transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray4, out hit, 5f))
		{}else{
			if(muki == 4)
				{
				 if(tonari != 3)
					{
					 playerB.transform.position = subB.transform.position + new Vector3(0, 0, -10);
					}
				}
		     }
	}
	if(subB.transform.position == playerB.transform.position)
	{
	 direct = 3;
	}
    }
}
