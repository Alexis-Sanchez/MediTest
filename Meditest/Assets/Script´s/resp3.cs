using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp3 : MonoBehaviour {

	static string respuesta1="Usar los virus en modificaciones de proteinas";
	static string respuesta2="Virus Proteicos";
	static string respuesta3="Incorrecta porque los plasmidos son ARN robosomal extracromosomico";
	static string respuesta4="Similaridad con bacterias patogenas";
	static string respuesta5="G2";
	static string respuesta6="Empaquetar y distribuir proteínas.";
	static string respuesta7="114";
	static string respuesta8="Cisteina";
	static string respuesta9="Proteínas y glucolípidos.";
	static string respuesta10="En medicina no es de gran importancia.";
	static string respuesta11="Porque nos permite agruparlos para estudiar mejor su hábitat.";
	static string respuesta12="Retículo endoplasmatico liso";
	static string respuesta13="Vacunas quiméricas producidas por estímulos en humanos para uso en humanos.";
	static string respuesta14="Baja";
	static string respuesta15="no hay síntesis proteica.";

	List<string> res3= new List<string>(){respuesta1,respuesta2,respuesta3,respuesta4,respuesta5
		,respuesta6,respuesta7,respuesta8,respuesta9,respuesta10,
		respuesta11,respuesta12,respuesta13,respuesta14,respuesta15};
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
