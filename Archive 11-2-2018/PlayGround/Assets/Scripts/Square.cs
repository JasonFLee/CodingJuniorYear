using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

    // Use this for initialization

    [SerializeField]
    GameObject ballPrefab;

    float speed = 2f;
    Vector3 velocity = new Vector3(0, 0, 0);
    void Start () {
        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
	}
    
	// Update is called once per frame
	void Update ()
    {

        
        float timer = 0;
        float overalltimetoreach = 0;

        timer += Time.deltaTime;
        if(timer > overalltimetoreach)
        {
            // GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            GetComponent<SpriteRenderer>().color = new Color( 1f, 1f, 1f);
            timer = 0;
        }
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0,0, transform.eulerAngles.z + 200 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }


        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }
    }
    void MovementWASD()
    {
        velocity = new Vector3(0, 0, 0);


        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 1)
            {
                velocity += Vector3.up;
            }

        }
        //
        Input.GetKey(KeyCode.A);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75f)
            {
                velocity += Vector3.left;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.75f)
            {
                velocity += Vector3.right;
            }


        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                velocity += Vector3.down;
            }

        }

       
    }

    public Vector3 LookAtDirection(float eulersAngleZ)
    {
        return new Vector3(Mathf.Cos(eulersAngleZ * Mathf.Deg2Rad), Mathf.Sin(eulersAngleZ * Mathf.Deg2Rad), 0);
        
    }
}
