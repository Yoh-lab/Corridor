using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BossTowerHP : MonoBehaviour
{

	public float maxHP=100;
	public float HP;
	public Canvas canvas;
	public Text text;
	public Slider _slider;

    void Start()
    {
	HP = maxHP;        
    }


    void Update()
    {
	_slider.value = HP;
	if(HP <= 0)
		{
		 SceneManager.LoadScene("Clear");
		}

    }

	void OnTriggerEnter(Collider collider)
	{
	 if(collider.gameObject.tag == "Bullet")
						{
	 					 HP -= 20f;
						}			 
			 		    					
	}
}
