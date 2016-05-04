using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Vector3 velocity = Vector3.zero;
    public float hoverForce = 100f;
    public float forwardSpeed = 10f;
    
    public Vector3 Gravity;
    public Vector3 HoverVelocity;
    public float maxSpeed = 5f;

    bool didHover = false;
    private Rigidbody2D playerRigidBody = null;


    void Awake() {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            didHover = true;
        }
        
    }
    
    void FixedUpdate() {
        #region rigidBodyAttempt
        //if(playerRigidBody != null) {
        //    playerRigidBody.AddForce(Vector2.right * forwardSpeed);



        //    if (didHover) {
        //        playerRigidBody.AddForce(Vector2.up * hoverForce);
        //        didHover = false;
        //    }


        //}

        //float angle = 0;

        //if (playerRigidBody.velocity.y < 0f) {
        //    angle = Mathf.Lerp(0f, -90f, -playerRigidBody.velocity.y / 4f);
        //}
        //else if (playerRigidBody.velocity.y > 0f) {
        //    angle = Mathf.Lerp(0f, 90f, playerRigidBody.velocity.y / 4f);
        //}

        //transform.rotation = Quaternion.Euler(0f, 0f, angle);
        #endregion

        
        velocity.x = forwardSpeed;
        velocity += Gravity * Time.deltaTime;

        if (didHover) {
            didHover = false;

            if (velocity.y < 0f) {
                velocity.y = 0f;
            }

            velocity += HoverVelocity;
        }

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;

        float angle = 0;

        if (velocity.y < 0f) {
            angle = Mathf.Lerp(0f, -90f, -velocity.y / maxSpeed);
        }
        else if (velocity.y > 0f) {
            angle = Mathf.Lerp(0f, 90f, velocity.y / maxSpeed);
        }

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
       
    }
}
