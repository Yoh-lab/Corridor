using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtonA : MonoBehaviour
{
	public float selectA = 1f;
	public float playerA = 0f;
	public PlayerStickA playerStickA;
	public WallStickA wallStickA;
	public StockButtonA stockButtonA;
	public GameObject stockA;
	public GameObject wallA;
	public GameObject PlayerA;
	public Material pink;
	public Material fadeGreen;
	public Material yellow;
	public Material fadeRed;


    void Start()
    {
	playerStickA = GameObject.Find("StickA").GetComponent<PlayerStickA>();
	wallStickA = GameObject.Find("StickA").GetComponent<WallStickA>();
	stockButtonA = GameObject.Find("StockA").GetComponent<StockButtonA>();
	stockA = GameObject.Find("StockA");
	wallA = GameObject.Find("WallA");
	PlayerA = GameObject.Find("PlayerA");
    }

    public void OnClicked()
    {
     if(selectA == 1)
     {
	switch(playerA)
			{
			 case 0:
				this.GetComponent<Renderer>().material = pink;
				wallA.GetComponent<Renderer>().material = fadeRed;
				stockA.GetComponent<Renderer>().material = fadeGreen;
				stockButtonA.stockA = 0;
				playerA ++;
				break;
			 case 1:
				this.GetComponent<Renderer>().material = yellow;
				PlayerA.GetComponent<Renderer>().material = yellow;
				playerStickA.enabled  = true;
				wallStickA.enabled = false;
				playerA = 0;
				selectA = 0;
 				break;
			}
     }	
    }

}
