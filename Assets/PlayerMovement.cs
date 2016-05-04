using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 0.5f;
    public float jumpHeight = 0.2f;
    public new Rigidbody2D rigidbody;
    
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.right * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space)) {
      
            rigidbody.AddForce(Vector2.up * 100f);

        }


	}
}
