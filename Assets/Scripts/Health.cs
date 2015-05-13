using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int healthPoints = 50;

	void OnTriggerEnter(Collider other) {

		if (other.CompareTag ("Player")) {
		
			other.SendMessage("GiveHealth", healthPoints);
			Destroy (gameObject);
		}
	}
}
