using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirectionA : MonoBehaviour
{
	public float rotate = 0f;
	public WallStickA wallStickA;
	public Material orange;
	public Material darkOrange;

    public void OnClicked()
    {
	if(rotate == 1)
	{
	 wallStickA = GameObject.Find("StickA").GetComponent<WallStickA>();
	 wallStickA.obj.transform.Rotate(Vector3.up * 90);	 
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
