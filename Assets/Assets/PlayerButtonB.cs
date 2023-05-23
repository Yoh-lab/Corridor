using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtonB : MonoBehaviour
{
	public float selectB= 0f;
	public float playerB = 0f;
	public PlayerStickB playerStickB;
	public WallStickB wallStickB;
	public StockButtonB stockButtonB;
	public GameObject stockB;
	public GameObject wallB;
	public GameObject PlayerB;
	public Material skiBlue;
	public Material fadeGreen;
	public Material yellow;
	public Material fadeBlue;


    void Start()
    {
	playerStickB = GameObject.Find("StickB").GetComponent<PlayerStickB>();
	wallStickB = GameObject.Find("StickB").GetComponent<WallStickB>();
	stockButtonB = GameObject.Find("StockB").GetComponent<StockButtonB>();
	stockB = GameObject.Find("StockB");
	wallB = GameObject.Find("WallB");
	PlayerB = GameObject.Find("PlayerB");
    }

    public void OnClicked()
    {
     if(selectB == 1)
     {
	switch(playerB)
			{
			 case 0:
				this.GetComponent<Renderer>().material = skiBlue;
				wallB.GetComponent<Renderer>().material = fadeBlue;
				stockB.GetComponent<Renderer>().material = fadeGreen;
				stockButtonB.stockB = 0;
				playerB ++;
				break;
			 case 1:
				this.GetComponent<Renderer>().material = yellow;
				PlayerB.GetComponent<Renderer>().material = yellow;
				playerStickB.enabled  = true;
				wallStickB.enabled = false;
				playerB = 0;
				selectB = 0;
 				break;
			}
     }	
    }

}
