using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStickA2 : MonoBehaviour
{
	public FloatingJoystick stick;
	public float hori;
	public float vert;
	public float muki;
	public GameObject subA;
	public GameObject playerA;
	public GameObject playerB;
	public float direct = 0f;
	public Material red;
	public Material blue;
	public Material green;
	public Material fade;
	public Material yellow;
	public GameObject wallA;
	public GameObject stockA;
	public GameObject turnA;
	public GameObject turnB;
	public float tonari;
	public AtariPlayerA mae;
	public AtariPlayerA usiro;
	public AtariPlayerA hidari;
	public AtariPlayerA migi;
	public PlayerStickA playerStickA;
	public  PlayerButtonA playerButtonA;
	public  PlayerButtonB playerButtonB;
	public  StockButtonA stockButtonA;
	public  StockButtonB stockButtonB;


    void Start()
    {
        stick = GameObject.Find("PlayerStickA").GetComponent<FloatingJoystick>();
	hori = stick.Horizontal;
	vert = stick.Vertical;
	subA = GameObject.Find("SubA");
	playerA = GameObject.Find("PlayerA");
	playerB = GameObject.Find("PlayerB");
	stockA = GameObject.Find("StockA");
	wallA = GameObject.Find("WallA");
	turnA = GameObject.Find("TurnA");
	turnB = GameObject.Find("TurnB");
	mae = GameObject.Find("mae").GetComponent<AtariPlayerA>();
	usiro = GameObject.Find("usiro").GetComponent<AtariPlayerA>();
	hidari = GameObject.Find("hidari").GetComponent<AtariPlayerA>();
	migi = GameObject.Find("migi").GetComponent<AtariPlayerA>();
	playerStickA =GameObject.Find("StickA").GetComponent<PlayerStickA>();
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
	subA.transform.position = playerA.transform.position;
	playerStickA.tonari = 0;
    }
    public void UpClicked()
    {
	if(direct == 1 && muki != 0)
	{
	 playerA.GetComponent<Renderer>().material = red;
	 wallA.GetComponent<Renderer>().material = red;
	 stockA.GetComponent<Renderer>().material = green;
	 turnA.GetComponent<Renderer>().material = fade;
	 turnB.GetComponent<Renderer>().material = blue;
	 playerB.GetComponent<Renderer>().material = blue;
	 muki = 0;
	 direct = 0;
	 stockButtonA.selectA  --; 
	 stockButtonB.selectB  ++;
	 playerButtonB.selectB ++;
	 enabled = false;
	}
    }

    void Update()
    {
	direct = 1;
	tonari = playerStickA.tonari;
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

	Ray ray1 =  new Ray(subA.transform.position, -transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray1, out hit, 5f))
		{}else{
			if(muki == 1)
				{
				 if(tonari != 2)
					{
					 playerA.transform.position = subA.transform.position + new Vector3(-10, 0, 0);
					}
				}
		     }
	}
	Ray ray2 =  new Ray(subA.transform.position, transform.right);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray2, out hit, 5f))
		{}else{
			if(muki == 2)
				 if(tonari != 1)
					{
					 playerA.transform.position = subA.transform.position + new Vector3(10, 0, 0);
					}
		     }
	}
	Ray ray3 =  new Ray(subA.transform.position, transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray3, out hit, 5f))
		{}else{
			if(muki == 3)
				{
				 if(tonari != 4)
					{
					 playerA.transform.position = subA.transform.position + new Vector3(0, 0, 10);
					}
				}
		     }
	}
	Ray ray4 =  new Ray(subA.transform.position, -transform.forward);
	{
	 RaycastHit hit;
	 if(Physics.Raycast(ray4, out hit, 5f))
		{}else{
			if(muki == 4)
				{
				 if(tonari != 3)
					{
					 playerA.transform.position = subA.transform.position + new Vector3(0, 0, -10);
					}
				}
		     }
	}
	if(subA.transform.position == playerA.transform.position)
	{
	 direct = 3;
	}
    }
}
