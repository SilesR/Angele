using UnityEngine;
using System.Collections;

public class claustrofobia : MonoBehaviour {

	Camera camara;
	public int angulacion = 1; // El factor muiedo indicará la velocidad con la que se reduce el campo de visión
	public int distancia = 1;

	// Use this for initialization

	void Start () {
		//Obtenemos el componente cámara del objeto en el que está insertado el script
		camara = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider target) {

				//if (claustrofobia) {

				camara.fieldOfView = camera.fieldOfView - Time.deltaTime * angulacion;

		//}

//			transform.position.z = new Vector3(0,0,transform.position.z - Time.deltaTime*distancia);
		}
}

