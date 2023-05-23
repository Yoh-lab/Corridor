using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionB : MonoBehaviour
{
	public float rotate = 0f;
	public WallStickB wallStickB;
	public Material orange;
	public Material darkOrange;


    public void OnClicked()
    {
	if(rotate == 1)
	{
	 wallStickB = GameObject.Find("StickB").GetComponent<WallStickB>();
	 wallStickB.obj.transform.Rotate(Vector3.up * 90);
	 
	}
    }

    public void UpClicked()
    {
	if(rotate == 1)
	{
	 this.GetComponent<Renderer>().material = orange;
	}
    }

    public void DownClicked()
    {
	if(rotate == 1)
	{
	 this.GetComponent<Renderer>().material = darkOrange;
	}
    }
}
