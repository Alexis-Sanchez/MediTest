using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp3 : MonoBehaviour {

	static string respuesta1="Usar los virus en modificaciones de proteinas";
	static string respuesta2="Virus Proteicos";
	static string respuesta3="Incorrecta porque los plasmidos son ARN robosomal extracromosomico";
	static string respuesta4="Similaridad con bacterias patogenas";
	static string respuesta5="G2";
	List<string> res3= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5,"Respuesta 6","respuesta 7","respuesta 8","respuesta 9","respuesta 10",
		"Respuesta 11","respuesta 12","respuesta 13","respuesta 14","respuesta 15"};
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = res3 [0];
	}

	// Update is called once per frame
	void Update () {
		if(Preguntas.RandPreg>-1){
			GetComponent<TextMesh> ().text = res3 [Preguntas.RandPreg];
		}
	}

	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		Preguntas.respSeleccionada = gameObject.name;
		Preguntas.seleccion= "y";
	}
}
