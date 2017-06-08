using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TrailRenderer _t = gameObject.AddComponent<TrailRenderer> ();
		_t.startWidth = 0.2f;
		_t.endWidth = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision _collision){
		if (_collision.transform.name == "killZone") {
			Debug.Log ("hoge");
			Destroy (gameObject);
		}
	}
}
