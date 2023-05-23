using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameMaster : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

        if (string.IsNullOrEmpty(PhotonNetwork.NickName))
        {
            PhotonNetwork.NickName = "player" + Random.Range(1, 99999);
        }
    }

    void OnGUI()
    {
        //ログインの状態を画面上に出力
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }

    //ルームに入室前に呼び出される
    public override void OnConnectedToMaster()
    {
        // "room"という名前のルームに参加する（ルームが無ければ作成してから参加する）
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }

    //ルームに入室後に呼び出される
    public override void OnJoinedRoom()
    {
	float[] vector = new float[5];
	vector[0] = -32.25f;
	vector[1] = -16f;
	vector[2] = 0f;
	vector[3] = 16f;
	vector[4] = 32.25f;
	float[] dx = new float[5];
	dx[0] = -32f;
	dx[1] = -16f;
	dx[2] = 0f;
	dx[3] = 16f;
	dx[4] = 32f;
	float[] dz = new float[6];
	dz[0] = 40f;
	dz[1] = 24f;
	dz[2] = 8f;
	dz[3] = -8f;
	dz[4] = -24f; 
	dz[5] = -40f;
        //ステージを生成
        GameObject stage = PhotonNetwork.Instantiate("Stage", new Vector3(0.0f, -0.1f, 0.0f), Quaternion.identity, 0);
        GameObject goalW = PhotonNetwork.Instantiate("GoalW", new Vector3(0.0f, 0.0f, -60f), Quaternion.identity, 0);
        GameObject goalB = PhotonNetwork.Instantiate("GoalB", new Vector3(0.0f, 0.0f, 60f), Quaternion.identity, 0);
	//スイッチを生成
	GameObject[] button = new GameObject[30];
	for(int i = 0; i <= 5; i++)
	{
	 for(int j = 0; j <= 4; j++)
	 {
	  button[i*5+j] = PhotonNetwork.Instantiate("Switch", new Vector3(dx[j], 0.0f, dz[i]), Quaternion.identity, 0);
	 }
	}
	
        //プレイヤーを生成
	GameObject[] player = new GameObject[10];
	for(int i = 0; i <= 4; i++)
	{
	 player[i] = PhotonNetwork.Instantiate("PlayerW1", new Vector3(vector[i], 3.0f, -40f), Quaternion.identity, 0);
	 player[i+5] = PhotonNetwork.Instantiate("PlayerB1", new Vector3(vector[i], 3.0f, 40f), Quaternion.identity, 0);
	}

	for(int i = 0; i <= 29; i++)
	{
	 for(int j = 0; j <= 9; j++)
	 {
	  button[i].GetComponent<Switch>().piece[j] = player[j].GetComponent<Piece>();
	  goalW.GetComponent<Switch>().piece[j] = player[j].GetComponent<Piece>();
	  goalB.GetComponent<Switch>().piece[j] = player[j].GetComponent<Piece>();
	 }
	}

	for(int i = 0; i <= 9; i++)
	{
	 button[i].GetComponent<Switch>().nocca = 1;
	 button[i+20].GetComponent<Switch>().nocca = 1;
	 player[i].GetComponent<Piece>().zibun = i+1;
	 for(int j = 0; j <= 9; j++)
	 {
	  player[i].GetComponent<Piece>().piece[j] = player[j].GetComponent<Piece>();
	  player[i].GetComponent<Piece>().player[j] = player[j];
	 }
	}
        //自分だけが操作できるようにスクリプトを有効にする
	Piece[] piece = new Piece[5];
	for(int i = 0; i <= 4; i++)
	{
	piece[i] = player[i].GetComponent<Piece>();
        piece[i].enabled = true;
	}
    }
}
