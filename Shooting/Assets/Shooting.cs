using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	// https://unity3d.sakura.ne.jp/unity/prefab.html

	// bullet prefab
	public GameObject bullet;
	// 弾丸発射点
	public Transform muzzle;
	// 弾丸の速度
	public float speed = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// zキーが押された時
		if (Input.GetMouseButton (0)) {
			Shoot ();
		}
		
	}

	void Shoot () {
		// 弾丸の複製
		GameObject bullets = GameObject.Instantiate(bullet)as GameObject;

//		Vector3 force;
//		force = this.gameObject.transform.forward * speed;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 direction = ray.direction;

		// Rigidbodyに力を加えて発射
		//			bullets.GetComponent<Rigidbody>().AddForce(force);
		bullets.GetComponent<Rigidbody>().useGravity = true;
//		bullets.GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 1000));
		bullets.GetComponent<Rigidbody>().AddForce(direction.normalized * 2000);
		bullets.GetComponent<Rigidbody>().AddTorque(new Vector3 (0, 10, 10));
		Debug.Log (direction.normalized);
		// 弾丸の位置を調整
		bullets.transform.position = muzzle.position;

		Destroy (bullets, 5);
	}
}
