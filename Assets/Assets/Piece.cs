using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Piece : MonoBehaviour
{
	public float[] count = new float[8];
	public float[] nocca = new float[8];
	public Contact[] contact = new Contact[8];
	public Contact ori;
	public Piece[] piece = new Piece[10];
	public Material black;
	public Material white;
	public Material color;
	public Material brown;
	public Material yellow;
	public int zibun;
	public int work = 0;
	public GameObject[] player =new GameObject[10];
	public GameObject sub;
	public float takasa = 1;
	

    void start()
    {
	 this.GetComponent<Renderer>().material = yellow;
	 work = 1;
   }

     void OnEnable()
     {
	if(takasa < ori.atari.GetComponent<Switch>().nocca)
	{
	 enabled = false;
	}else
	{
	 this.GetComponent<Renderer>().material = yellow;
	 work = 1;
	}
     }

    public void OnClicked()
    {
      if(work == 1)
      {
	ori.atari.GetComponent<Switch>().nocca -= 1;
	for(int i = 1; i <= 10; i++)
	{
	 if(i != zibun)
	 {
	  piece[i-1].work = 0;
	  piece[i-1].enabled = false;
	  if(i <= 5)
	  {
	   player[i-1].GetComponent<Renderer>().material = white;
	  }else
	  {
	   player[i-1].GetComponent<Renderer>().material = black;
	  }
	 }
	}

	for(int i = 0; i <= 7; i++)
	{
	 count[i] = contact[i].count;
	 if(count[i] == 1)
	 {
	  nocca[i] = contact[i].atari.GetComponent<Switch>().nocca;
	 }
	 if(count[i] == 1 && nocca[i] <= 2)
	 {
	  contact[i].atari.GetComponent<Renderer>().material = yellow;
	  contact[i].atari.GetComponent<Switch>().work = true;
	  contact[i].atari.GetComponent<Switch>().team = zibun;
	 }
	 if(count[i] == 2 && zibun >= 6)
	 {
	  contact[i].atari.GetComponent<Renderer>().material = yellow;
	  contact[i].atari.GetComponent<Switch>().work = true;
	  contact[i].atari.GetComponent<Switch>().team = zibun;
	 }
	 if(count[i] == 3 && zibun <= 5)
	 {
	  contact[i].atari.GetComponent<Renderer>().material = yellow;
	  contact[i].atari.GetComponent<Switch>().work = true;
	  contact[i].atari.GetComponent<Switch>().team = zibun;
	 }
	}
       work =2;
      }
    }
    void OnDisable()
    {
      if(work == 2)
      {
	for(int i = 0; i <= 7; i++)
	{
	 this.GetComponent<Renderer>().material = color;
	 if(count[i] == 1 )
	 {
	  if(contact[i].atari.GetComponent<Switch>().decide == true)
	  {
	    switch ( nocca[i] )
		{
		 case 0:
		 	this.transform.position = contact[i].atari.transform.position + new Vector3(0, 3, 0);
			sub.transform.position = contact[i].atari.transform.position + new Vector3(0, 0, 0);
			break;
		 case 1:
			this.transform.position = contact[i].atari.transform.position + new Vector3(0, 7, 0);
			sub.transform.position = contact[i].atari.transform.position + new Vector3(0, 0, 0);
			break;
		 case 2:
			this.transform.position = contact[i].atari.transform.position + new Vector3(0, 11, 0);
			sub.transform.position = contact[i].atari.transform.position + new Vector3(0, 0, 0);
			break;
		}

	   contact[i].atari.GetComponent<Renderer>().material = brown;
	   takasa =  contact[i].atari.GetComponent<Switch>().nocca;
	   contact[i].atari.GetComponent<Switch>().work = false;
	   contact[i].atari.GetComponent<Switch>().decide = false;
	   contact[i].atari.GetComponent<Switch>().team = 0;
	  }else 
	  {
	   contact[i].atari.GetComponent<Renderer>().material = brown;
	   contact[i].atari.GetComponent<Switch>().work = false;
	   contact[i].atari.GetComponent<Switch>().team = 0;
	  }
	}
	if(count[i] == 2)
	 {
	 contact[i].atari.GetComponent<Renderer>().material = white;
	 contact[i].atari.GetComponent<Switch>().work = false;
	 contact[i].atari.GetComponent<Switch>().team = 0; 
	 if(contact[i].atari.GetComponent<Switch>().decide == true)
	   {
	    this.transform.position = contact[i].atari.transform.position + new Vector3(0, 3, 0);
	    SceneManager.LoadScene("NoccaNoccaWinnerB"); 
	   } 
	 }
	if(count[i] == 3)
	 {
	 contact[i].atari.GetComponent<Renderer>().material = black;
	 contact[i].atari.GetComponent<Switch>().work = false;
	 contact[i].atari.GetComponent<Switch>().team = 0;  
	 if(contact[i].atari.GetComponent<Switch>().decide == true)
	   {
	    this.transform.position = contact[i].atari.transform.position + new Vector3(0, 3, 0);
	    SceneManager.LoadScene("NoccaNoccaWinnerW"); 
	   } 
	 }
	}
	work =0;
      }
    }
}
