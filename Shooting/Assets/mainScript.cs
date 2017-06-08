using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			// 生成
			GameObject _s = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			_s.transform.position = new Vector3 (0, 0.5f, 0);

			float _size = Random.Range (0.2f, 1.0f);
			_s.transform.localScale = new Vector3 (_size, _size, _size);


			_s.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
		

//			GameObject _empty = new GameObject('scene');
			Rigidbody _r = _s.AddComponent<Rigidbody>();
			_s.AddComponent<killCheck> ();

			//			_r.AddForce (new Vector3 (0, 0, 1.0f), ForceMode.Impulse);
			float _power = 3.0f;
//			_r.AddForce (Random.insideUnitSphere * _power, ForceMode.Impulse);
			_r.AddForce (new Vector3(
				Random.Range(-1.0f, 1.0f),
				Random.Range(0.0f, 8.0f),
				5.0f
			), ForceMode.Impulse);

			// random
			/*
			float _val0 = Random.value; // 0.0f - 1.0f
			float _val1 = Random.Range(0.0f, 1.0f); 
			float _val2 = Random.Range(10.0f, 20.0f);
			int _val3 = Random.Range (5, 10);

			Vector3 _val4 = Random.insideUnitSphere; // 
			Vector2 _val5 = Random.insideUnitCircle * _val2;

			float _val6 = Mathf.PerlinNoise (0.0f, 0.0f);
			*/

		}
	}
}
