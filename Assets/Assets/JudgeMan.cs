using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JudgeMan : MonoBehaviour
{
	public GameObject playerA;
	public GameObject playerB;
    void Start()
    {
	playerA = GameObject.Find("PlayerA");
	playerB = GameObject.Find("PlayerB");
    }

    void Update()
    {
	if(playerA.transform.position.z >= 40f)
	{
	 SceneManager.LoadScene("CorridorWinnerA");
	}
	if(playerB.transform.position.z <= -40f)
	{
	 SceneManager.LoadScene("CorridorWinnerB");
	}

    }
}


