using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour
{

	private int count;

	void Start ()
	{
		count = 0;
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Gold")
		{
			other.gameObject.SetActive(false);
			count = count + 1;
	}
	
	}
}