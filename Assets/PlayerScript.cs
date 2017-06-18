using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : Photon.MonoBehaviour
{

	void FixedUpdate ()
	{
		if (!(photonView.isMine)) {
			return;
		}

//		float h = Input.GetAxis ("Horizontal");
//		float v = Input.GetAxis ("Vertical");
//		anim.SetFloat ("Speed", v);                          
//		anim.SetFloat ("Direction", h);                      
//		anim.speed = animSpeed;             
//		currentBaseState = anim.GetCurrentAnimatorStateInfo (0);
//		rb.useGravity = true;
	}




	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
