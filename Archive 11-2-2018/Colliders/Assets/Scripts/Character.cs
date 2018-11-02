using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    float jump = 3;
    float speed = 2;
    public List<Vector3> teleportLocations = new List<Vector3>();
    bool jumppp;

    Vector3 velocity= new Vector3(0,0,0);
    Rigidbody2D rbody;
	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
        jumppp = false;
        GameManager.Instance.MyCharacter = this;
    }
	
	// Update is called once per frame
	void Update () 
    {
        velocity = rbody.velocity;
     
        if (Input.GetKeyDown(KeyCode.W)&& jumppp == true)
        {
            velocity += Vector3.up * jump;
            jumppp = false;
          //  AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * Time.deltaTime * speed;
        }
        if(!Input.GetKey(KeyCode.A)&& !Input.GetKeyDown(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime* 5), velocity.y, 0);
            
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -3f, 3f), 0) ;

    }

    public void OnclickTeleportButtin()
    {
        transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            
            jumppp = true;
        }
        if (collision.collider.tag == "death")
        {

            Application.LoadLevel("clipit");


        }
    }
}
