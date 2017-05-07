using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp4 : MonoBehaviour {

	static string respuesta1="Usar los virus para infectar priones";
	static string respuesta2="Virus ARN no retrovirus";
	static string respuesta3="Ninguna de las anteriores";
	static string respuesta4="Rapido crecimiento";
	static string respuesta5="S";
	List<string> res4= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,"Respuesta 6","respuesta 7","respuesta 8","respuesta 9","respuesta 10",
		"Respuesta 11","respuesta 12","respuesta 13","respuesta 14","respuesta 15"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = res4 [0];
	}

	// Update is called once per frame
	void Update () {
		if(Preguntas.RandPreg>-1){
			GetComponent<TextMesh> ().text = res4 [Preguntas.RandPreg];
		}
	}

	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		Preguntas.respSeleccionada = gameObject.name;
		Preguntas.seleccion= "y";
	}
}
