using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp1 : MonoBehaviour {

	static string respuesta1="Usar los virus como transporte para insertar genes en celulas";
	static string respuesta2="Virus ADN";
	static string respuesta3="Incorrecta porque los plasmidos son ARN del cromosoma bacteriano";
	static string respuesta4="Genomas complejos";
	static string respuesta5="G0";
	List<string> res1= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,"Respuesta 6","respuesta 7","respuesta 8","respuesta 9","respuesta 10",
		"Respuesta 11","respuesta 12","respuesta 13","respuesta 14","respuesta 15"};

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = res1 [0];
	}

	// Update is called once per frame
	void Update () {
		if(Preguntas.RandPreg>-1)
		{
			GetComponent<TextMesh> ().text = res1 [Preguntas.RandPreg];
		}
	}

	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		Preguntas.respSeleccionada = gameObject.name;
		Preguntas.seleccion= "y";
	}
}
