using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject player;
    float offesetX;
    Transform playerTransform;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null) {
            Debug.Log("Player not instanced");
        }

        playerTransform = player.transform;
        offesetX = transform.position.x - playerTransform.position.x;

    }
	
	// Update is called once per frame
	void Update () {

        if(playerTransform != null) {
            Vector3 pos = transform.position;
            pos.x = playerTransform.position.x + offesetX;
            transform.position = pos;
        }

	
	}
}
