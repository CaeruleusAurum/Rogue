using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {

	Slider slider;

	void Start () {
	
		slider = GetComponent<Slider> ();
	}

	void SetValue(float value) {

		slider.value = value;
	}
}
