using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour 
{
	static string pregunta1="Los virus poseen genomas sencillos que tienen toda la informacion \n para sintetizar sus propias proteinas utilizando la celula que infecta para este fin,\n deacuerdo con esto podriamos pensar: ";
	static string pregunta2 = "La replicacion viral puede causar daños en el genoma de una celula \n lo que ocaciona que eta pueda volverce cancerigena,\n los virus implicados en este'proceso a la fecha se cree que son:";
	static string pregunta3 = "Los plasmidos son moleculas de aminoacidos que le permiten a las bacterias \n poseer ventajas en condiciones de crecimiento determinadas,\n la frase es: ";
	static string pregunta4 = "En los laboratorios de investigacion es utilizado muchas veces modelos celulares\n bacterianos como E. coli.\n ¿Cual es una de las ventajas para utilizar este tipo de organismis\n y no celulas eucariotas";
	static string pregunta5 = "¿En cual de las fases de ciclo celular\n aumenta la posibilidad de generarse una mutacion?";
	List<string> p = new List<string>(){pregunta1,pregunta2,pregunta3,pregunta4
		,pregunta5,"pregunta 6","pregunta 7","pregunta 8","pregunta 9","pregunta 10"
		,"pregunta 11","pregunta 12","pregunta 13","pregunta 14","pregunta 15"};

	List<string> respCorrecta = new List<string>(){"1","1","2","4","4","4","1","2","4","3","4","1","2","4","3"};

	public static string respSeleccionada;
	public Transform objetoResultado;
	public static string seleccion="n";

	public static int RandPreg=-1;

	public int cateModificacion = 0;
	// Use this for initialization
	void Start () 
	{
		if(Escenario.categoria=="categoria 1")
		{
			cateModificacion = 0;

		}
		if(Escenario.categoria=="categoria 2")
		{
			cateModificacion = 5;

		}
		if(Escenario.categoria=="categoria 3")
		{
			cateModificacion = 10;

		}
		//GetComponent<TextMesh> ().text = p [0];

	}

	// Update is called once per frame
	void Update () 
	{
		if(RandPreg==-1)
		{
			RandPreg = Random.Range (0+cateModificacion, 5+cateModificacion);
		}
		if(RandPreg>-1)
		{
			GetComponent<TextMesh> ().text = p [RandPreg];
		}

		//Debug.Log (p[RandPreg]);
		if (seleccion == "y") 
		{
			seleccion="n";


			if (respCorrecta [RandPreg] == respSeleccionada) 
			{
				objetoResultado.GetComponent<TextMesh> ().text = "Correcto!!";

				//Debug.Log ("correcto"+" "+RandPreg);
			} else {
				objetoResultado.GetComponent<TextMesh> ().text = "Incorrecto!!";

			}


		}

	}
}
