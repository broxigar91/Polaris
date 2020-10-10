using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	public float speed; // kecepatan
	public Vector2 pos; // posisi dimana bg baru keluar dari kamera

	void Start (){
	}

	void Update () {
		transform.Translate (new Vector2 (-speed * Time.deltaTime, 0));

		if (transform.position.x < pos.x)
			transform.position = new Vector3 (-pos.x, transform.position.y, transform.position.z);
	
		

	}
}