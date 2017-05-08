using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp2 : MonoBehaviour {
	static string respuesta1="Usar los virus para eliminar celulas bacterianas";
	static string respuesta2="Bacteriofagos";
	static string respuesta3="Correcta porque los plasmidos permiten sintetizar enzimas para degradar antibioticos";
	static string respuesta4="Celulas mas exigentes por lo cual son mas especificas";
	static string respuesta5="G1";
	static string respuesta6="Síntesis de proteínas.";
	static string respuesta7="131";
	static string respuesta8="Glicina";
	static string respuesta9="ARN";
	static string respuesta10="Porque permite diseñar tratamientos específicos.";
	static string respuesta11="Porque nos permite conocer mejor como se comportaran en el organismo";
	static string respuesta12="Ribosoma";
	static string respuesta13="Vacunas, producidas mediante tecnologías de ADN recombinante";
	static string respuesta14="Elevada";
	static string respuesta15="Se produce la proteína en el citoplasma y hay un retraso en la llegada al retículo.";

	List<string> res2= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,respuesta6,respuesta7,respuesta8,respuesta9,respuesta10,
		respuesta11,respuesta12,respuesta13,respuesta14,respuesta15};

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
