using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockButtonA : MonoBehaviour
{
	public float selectA = 1f;
	public float stockA = 0f;
	public WallStickA wallStickA;
	public PlayerStickA playerStickA;
	public PlayerButtonA playerButtonA;
	public GameObject playerA;
	public GameObject playerB;
	public GameObject wallA;
	public Material pink;
	public Material darkGreen;
	public Material fade;
	public Material red;
	public Material blue;
	public Material green;
	public Material yellow;
	public Material fadeRed;
	public Material fadeGreen;
	public float ammo = 10f;
	public Text text;
	public Collider collider;
	public Atari ata;
	public float number;
	public  PlayerButtonB playerButtonB;
	public  StockButtonB stockButtonB;



    void Start()
    {
	wallStickA = GameObject.Find("StickA").GetComponent<WallStickA>();
	playerStickA = GameObject.Find("StickA").GetComponent<PlayerStickA>();
	playerButtonA = GameObject.Find("TurnA").GetComponent<PlayerButtonA>();
	playerA = GameObject.Find("TurnA");
	playerB = GameObject.Find("TurnB");
	wallA = GameObject.Find("WallA");
        playerButtonB = GameObject.Find("TurnB").GetComponent<PlayerButtonB>();
        stockButtonB = GameObject.Find("StockB").GetComponent<StockButtonB>();
    }

    public void OnClicked()
    {
     if(selectA == 1)
     {
	if(ammo == 0)
	{
	 if(stockA == 2)
		{
		ata = wallStickA.obj.GetComponent<Atari>();
		number = ata.atari;
		if(number == 0)
		{
	 	 wallA.GetComponent<Renderer>().material = fadeRed;
	 	 this.GetComponent<Renderer>().material = fadeGreen;
	 	 playerA.GetComponent<Renderer>().material = fade;
		 playerB.GetComponent<Renderer>().material = blue;
	 	 wallStickA.obj.GetComponent<Renderer>().material = red;
		 wallStickA.enabled = false;
		 collider = wallStickA.obj.GetComponent<BoxCollider>();
		 collider.isTrigger =  true;
		 selectA  --; 
		 stockButtonB.selectB  ++;
		 playerButtonB.selectB ++;
		 stockA = 0;
		}
		}
	}
      if(ammo >= 1)
	{
	 switch(stockA)
			{
			 case 0:
				playerButtonA.playerA = 0;
				this.GetComponent<Renderer>().material = darkGreen;
				wallA.GetComponent<Renderer>().material = pink;
				playerA.GetComponent<Renderer>().material = fadeRed;
				stockA ++;
				break;
			 case 1:
				this.GetComponent<Renderer>().material = green;
				wallA.GetComponent<Renderer>().material = yellow;
				playerStickA.enabled  = false;
				wallStickA.enabled = true;
				stockA = 2;
				playerButtonA.selectA --;
				ammo --;
				Text ammoMessage;
				ammoMessage = text.GetComponent<Text>();
				ammoMessage.text = "X" + ammo ;
 				break;
			 case 2:
				ata = wallStickA.obj.GetComponent<Atari>();
				number = ata.atari;
				if(number == 0)
				{
				this.GetComponent<Renderer>().material = green;
				wallA.GetComponent<Renderer>().material = red;
				playerA.GetComponent<Renderer>().material = fade;
				playerB.GetComponent<Renderer>().material = blue;
				wallStickA.obj.GetComponent<Renderer>().material = red;
				wallStickA.enabled = false;
				collider = wallStickA.obj.GetComponent<BoxCollider>();
				collider.isTrigger =  true;
	 			stockButtonB.selectB  ++;
	 			playerButtonB.selectB ++;
	 			selectA  --; 
				stockA = 0;
				}
				break;
			}
	}
    }
   }

}
