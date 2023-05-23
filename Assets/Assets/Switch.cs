using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Switch : MonoBehaviour
{
	public int team = 0;
	public float nocca =0f;
	public bool work = false;
	public bool decide = false;
	public Piece[] piece = new Piece[10];

    public void OnClicked()
    {
     if(work == true)
       {
	decide = true;
	nocca ++;
	if(team <= 5)
	{
	 for(int i = 5; i <= 9; i++)
	 {
	  piece[i].enabled = true;
	 }
	}else
	{
	 for(int i = 0; i <= 4; i++)
	 {
	  piece[i].enabled = true;
	 }
	}
	piece[team-1].enabled = false;
       }
    }
}
