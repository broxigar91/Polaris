using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VOLVER : MonoBehaviour {

	public void cambiarescena (){
		Debug.Log ("Start Scene");
		SceneManager.LoadScene ("Start Scene");

	}
}
