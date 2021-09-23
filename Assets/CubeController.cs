using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //test
    public float speed = 5f;
    public float jumpSpeed = 10f;
    public float jumpCoolDown = 0f;
   void Update() {
       //vitesse
      // transform.position = transformm.position + Vector3right * 0.2f;
        Rigidbody body = GetComponent<Rigidbody>();

        Vector3 move = new Vector3 (2f, 0f, 1f);

        move.x = speed * Input.GetAxis("Horizontal");
        move.y = body.velocity.y;
        move.z = speed * Input.GetAxis("Vertical");

        jumpCoolDown = jumpCoolDown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && jumpCoolDown <= 0){
            jumpCoolDown = 1.5f;
            move.y = jumpSpeed;
        }

        body.velocity = move;
        }
}

