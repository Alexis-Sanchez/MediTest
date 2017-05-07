using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Escenario : MonoBehaviour {

	public static string categoria;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		categoria = gameObject.name;
		SceneManager.LoadScene ("Escenario");
	}
}
