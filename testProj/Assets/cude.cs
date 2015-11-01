using UnityEngine;
using System.Collections;

public class cude : MonoBehaviour {

	float elapsed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;
		if(elapsed >= 1f)
		{
			elapsed = 0f;
			transform.position = transform.position + transform.up;
		}
	}
}
