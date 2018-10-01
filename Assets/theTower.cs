﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theTower : MonoBehaviour {

	private hearts hearts;

	// Use this for initialization
	void Start () {
		hearts = GameObject.Find ("hearts").GetComponent<hearts> ();
	}

	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter( Collision bang ){
		foreach (ContactPoint contact in bang.contacts) {
			Collider other = contact.otherCollider;
			if (other.CompareTag ("enemyProjectile")) {
				loseLife ();
			}
		}
	}

	public void loseLife(){
		hearts.loseLife ();
	}


}
