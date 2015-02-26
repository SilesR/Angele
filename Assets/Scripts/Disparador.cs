using UnityEngine;
using System.Collections;

public class Disparador : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();
		animator.SetBool("DisparadorLiquido", false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider target){

		animator.SetBool("DisparadorLiquido", true);
	}
}
