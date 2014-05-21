﻿using UnityEngine;
using System.Collections;

public class PressScript : MonoBehaviour {


	Animator animator;
	public string key_1 = "a";
	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKeyDown (key_1))
						PlayNote ();
						//animator.SetTrigger ("DoPress");
				if (Input.GetKeyUp (key_1))
						animator.SetTrigger ("UnPress");

				
		}

	void OnMouseDown (){
			PlayNote();
			//animator.SetTrigger ("DoPress");
	}

	void OnMouseUp ()
	{
		animator.SetTrigger ("UnPress");
	}

	
	void PlayNote(){

		audio.Play ();
		animator.SetTrigger ("DoPress");

	}			
}
