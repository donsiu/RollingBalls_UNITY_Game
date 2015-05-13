using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		Vector3 v3 = new Vector3 (15,30,45);
		transform.Rotate (v3 * Time.deltaTime);
	}
}
