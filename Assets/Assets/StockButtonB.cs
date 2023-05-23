using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockButtonB : MonoBehaviour
{
	public float selectB = 0f;
	public float stockB = 0f;
	public WallStickB wallStickB;
	public PlayerStickB playerStickB;
	public PlayerButtonB playerButtonB;
	public GameObject playerA;
	public GameObject playerB;
	public GameObject wallB;
	public Material skiBlue;
	public Material darkGreen;
	public Material fade;
	public Material blue;
	public Material red;
	public Material green;
	public Material yellow;
	public Material fadeBlue;
	public Material fadeGreen;
	public float ammo = 10f;
	public Text text;
	public Collider collider;
	public Atari ata;
	public float number;
	public  PlayerButtonA playerButtonA;
	public  StockButtonA stockButtonA;



    void Start()
    {
	wallStickB = GameObject.Find("StickB").GetComponent<WallStickB>();
	playerStickB = GameObject.Find("StickB").GetComponent<PlayerStickB>();
	playerButtonB = GameObject.Find("TurnB").GetComponent<PlayerButtonB>();
	playerB = GameObject.Find("TurnB");
	playerA = GameObject.Find("TurnA");
	wallB = GameObject.Find("WallB");
        playerButtonA = GameObject.Find("TurnA").GetComponent<PlayerButtonA>();
        stockButtonA = GameObject.Find("StockA").GetComponent<StockButtonA>();
    }

    public void OnClicked()
    {
     if(selectB == 1)
     {
	if(ammo == 0)
	{
	 if(stockB == 2)
		{
		ata = wallStickB.obj.GetComponent<Atari>();
		number = ata.atari;
		if(number == 0)
		{
	 	 wallB.GetComponent<Renderer>().material = fadeBlue;
	 	 this.GetComponent<Renderer>().material = fadeGreen;
	 	 playerB.GetComponent<Renderer>().material = fade;
		 playerA.GetComponent<Renderer>().material = red;
	 	 wallStickB.obj.GetComponent<Renderer>().material = blue;
		 wallStickB.enabled = false;
		 collider = wallStickB.obj.GetComponent<BoxCollider>();
		 collider.isTrigger =  true;
	 	 stockButtonA.selectA  ++; 
	 	 playerButtonA.selectA ++;
		 selectB = 0;
		 stockB = 0;
		}
		}
	}	
      if(ammo >= 1)
	{
	 switch(stockB)
			{
			 case 0:
				playerButtonB.playerB = 0;
				this.GetComponent<Renderer>().material = darkGreen;
				wallB.GetComponent<Renderer>().material = skiBlue;
				playerB.GetComponent<Renderer>().material = fadeBlue;
				stockB ++;
				break;
			 case 1:
				this.GetComponent<Renderer>().material = green;
				wallB.GetComponent<Renderer>().material = yellow;
				playerStickB.enabled  = false;
				wallStickB.enabled = true;
				stockB = 2;
				playerButtonB.selectB --;
				ammo --;
				Text ammoMessage;
				ammoMessage = text.GetComponent<Text>();
				ammoMessage.text = "X" + ammo ;
 				break;
			 case 2:
				ata = wallStickB.obj.GetComponent<Atari>();
				number = ata.atari;
				if(number == 0)
				{
				this.GetComponent<Renderer>().material = green;
				wallB.GetComponent<Renderer>().material = blue;
				playerB.GetComponent<Renderer>().material = fade;
				playerA.GetComponent<Renderer>().material = red;
				wallStickB.obj.GetComponent<Renderer>().material = blue;
				wallStickB.enabled = false;
				collider = wallStickB.obj.GetComponent<BoxCollider>();
				collider.isTrigger =  true;
	 			stockButtonA.selectA  ++; 
	 			playerButtonA.selectA ++;
				selectB = 0;
				stockB = 0;
				}
				break;
			}
	}
    }
   }

}