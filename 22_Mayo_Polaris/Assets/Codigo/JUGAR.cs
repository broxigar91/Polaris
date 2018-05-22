using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JUGAR : MonoBehaviour {

	void awake()	{	
		DontDestroyOnLoad(gameObject);	
	}
	public void cambiarescena (){
		Debug.Log ("PLAYMODE");
		SceneManager.LoadScene ("PLAYMODE");

	}
}
