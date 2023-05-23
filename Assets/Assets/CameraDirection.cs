using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraDirection : MonoBehaviour
{
	public Slider slider;


    void Update()
    {
	this.transform.eulerAngles = new Vector3(0, slider.value, 0);
	 
    }
}
