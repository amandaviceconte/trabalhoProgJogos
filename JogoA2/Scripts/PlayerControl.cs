using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject player;
	public float maxSceneHeight;
	public float minSceneHeight;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float tranlation = Input.GetAxis ("Vertical") * speed;
		player.transform.Translate (0, tranlation, 0);

		if (player.transform.position.y > maxSceneHeight) {
			player.transform.position = new Vector3(0, maxSceneHeight, -10);
		}

		if (player.transform.position.y < minSceneHeight) {
			player.transform.position = new Vector3(0, minSceneHeight, -10);
		}
	}
}
