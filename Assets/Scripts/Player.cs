﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 1;
	public Transform healthBar;
	CharacterController controller;

	int maxHitPoints = 100;
	int hitPoints = 50;

	// Use this for initialization
	void Start () {
	
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		controller.Move (move * Time.deltaTime * speed);

		healthBar.SendMessage ("SetValue", (float)hitPoints / (float)maxHitPoints);
	}

	void GiveHealth(int health) {
		
		hitPoints = Mathf.Min (maxHitPoints, hitPoints + health);
	}

	void DoDamage(int damage) {
		
		hitPoints = Mathf.Max (0, hitPoints - damage);
		if (hitPoints == 0) {

			Destroy (gameObject);
		}
	}
}
