using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;

	public Text countext;
	public Text wintext;
	private Rigidbody rb;

	public int count;

	void SetcountText()
	{
		countext.text = "Score:" + count.ToString();
		if (count >= 9)
		{
			wintext.text = "You Win";

		}
	}
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		 count = 0;
		SetcountText();
		wintext.text = "";

	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

//		Debug.LogWarning (moveHorizontal);
//		Debug.LogWarning (moveVertical);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

	void  OnTriggerEnter(Collider collid)
	{
		if (collid.gameObject.CompareTag ("Pick Up")) {
			collid.gameObject.SetActive(false);
			count ++;
			SetcountText();
		}

		//Destroy (other.gameObject);

	}
}