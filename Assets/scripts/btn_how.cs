﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btn_how : MonoBehaviour, IPointerClickHandler {

	private flingyBall game;


	// Use this for initialization
	void Start () {
		game= GameObject.Find ("Manager").GetComponent<flingyBall> ();
	}

	// Update is called once per frame
	void Update () {

	}



	public void OnPointerClick( PointerEventData data){
		Debug.Log( "How to play" );
		// this object was clicked - do something
		game.playTutorial();
	} 
}
