using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject player;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {

        if(player != null) {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            //transform.Translate(new Vector3(player.transform.position.x, 0, 0));
        } else {
            Debug.Log("Player not instanced");
        }
	
	}
}
