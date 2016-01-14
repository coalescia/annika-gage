using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerBehaviour : MonoBehaviour {


	public Text scoretext;
	private int score = 0;
	private Rigidbody rbody;

	public Text winText;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		float verticalMovement = Input.GetAxis ("Vertical");
		rbody.AddForce (new Vector3 (horizontalMovement, 0, verticalMovement)); 
		

	}

	void OnTriggerEnter(Collider trigger) {
		trigger.gameObject.SetActive (false);
		UpdateScore (score + 1);
	}


void UpdateScore(int newScore) {
		score = newScore;
		scoretext.text = "Score: " + newScore;

		if (score > 3) {
			winText.gameObject.SetActive(true);
		}
	}
}
