using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp1 : MonoBehaviour {

	static string respuesta1="Usar los virus como transporte para insertar genes en celulas";
	static string respuesta2="Virus ADN";
	static string respuesta3="Incorrecta porque los plasmidos son ARN del cromosoma bacteriano";
	static string respuesta4="Genomas complejos";
	static string respuesta5="G0";
	static string respuesta6="Procesos de glicosilación en proteínas";
	static string respuesta7="148";
	static string respuesta8="Metionina";
	static string respuesta9="ADN";
	static string respuesta10="Porque nos permite agruparlos para estudiar mejor su hábitat";
	static string respuesta11="Porque permite diseñar tratamientos específicos";
	static string respuesta12="Retículo endoplasmatico rugoso";
	static string respuesta13="Vacunas de ARNt";
	static string respuesta14="Normal";
	static string respuesta15="no hay correcta distribución de la proteína,\n la ruta de transporte y la eficiencia de secreción se puede inhibir.";

	List<string> res1= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,respuesta6,respuesta7,respuesta8,respuesta9,respuesta10,
		respuesta11,respuesta12,respuesta13,respuesta14,respuesta15};

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
