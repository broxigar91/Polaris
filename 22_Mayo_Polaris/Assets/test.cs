using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            AudioManager.instance.Play("derrota");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AudioManager.instance.Play("victoria");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AudioManager.instance.Play("disparo");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AudioManager.instance.Play("damage");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AudioManager.instance.Play("intro");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            AudioManager.instance.Play("game");
        }
    }

}
