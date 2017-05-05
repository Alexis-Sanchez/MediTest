using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp2 : MonoBehaviour {
	static string respuesta1="Usar los virus para eliminar celulas bacterianas";
	static string respuesta2="Bacteriofagos";
	static string respuesta3="Correcta porque los plasmidos permiten sintetizar enzimas para degradar antibioticos";
	static string respuesta4="Celulas mas exigentes por lo cual son mas especificas";
	static string respuesta5="G1";
	List<string> res2= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,"Respuesta 6","respuesta 7","respuesta 8","respuesta 9","respuesta 10",
		"Respuesta 11","respuesta 12","respuesta 13","respuesta 14","respuesta 15"};

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = res2 [0];
	}

	// Update is called once per frame
	void Update () {
		if(Preguntas.RandPreg>-1){
			GetComponent<TextMesh> ().text = res2 [Preguntas.RandPreg];
		}
	}

	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		Preguntas.respSeleccionada = gameObject.name;
		Preguntas.seleccion= "y";
	}
}
