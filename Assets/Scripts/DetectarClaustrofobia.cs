using UnityEngine;
using System.Collections;

public class DetectarClaustrofobia : MonoBehaviour {

	public bool claustrofobiasi=false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider target){

		if (target.transform.tag == "Player") {

//			GameControl.claustrofobia=true;


				}


	}
}
