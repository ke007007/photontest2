using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonController : MonoBehaviour
{

	public GameObject player;

	// Use this for initialization
	void Start ()
	{
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}

	void OnJoinedLobby ()
	{
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed ()
	{
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom ()
	{
		PhotonNetwork.Instantiate (
			player.name,
			new Vector3 (2f, 1f, -3f),
			Quaternion.identity,
			0
		);

		GameObject mainCamera = GameObject.FindWithTag ("MainCamera");
//		mainCamera.GetComponent <ThirdPersonCamera> ().enabled = true;

	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
