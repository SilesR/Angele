using UnityEngine;
using System.Collections;

public class Muerte : MonoBehaviour {
	public string nameLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider target){
		if (target.transform.tag == "Player") {
			Application.LoadLevel(nameLevel);
		}
	}
}
