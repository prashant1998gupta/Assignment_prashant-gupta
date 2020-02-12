using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_controller : MonoBehaviour
{
    public float Value = 10f;
    Rigidbody rb;

    // Start is called before the first frame update

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        StartCoroutine ( Pause());
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x > 25)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;

            ScoreBoard_Controller.instance.Giveplayer_1Piont();
            StartCoroutine(Pause());
        }


        if (transform.position.x < -25)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;

            ScoreBoard_Controller.instance.Giveplayer_2Piont();
            StartCoroutine(Pause());
        }

    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2f);
        LaunchBall();
    }

    void LaunchBall()
    {

        
        

        int xDirection = Random.Range(0, 2);

        int yDirection = Random.Range(0, 3);

        Vector3 lauchDirection = new Vector3();

        if (xDirection == 0)
        {
            lauchDirection.x = -(Value);
        }


        if (xDirection == 1)
        {
            lauchDirection.x = (Value);
        }


        /*if (xDirection == 2)
        {
            lauchDirection.x = 8f;
        }*/

        if (yDirection == 0)
        {
            lauchDirection.y = -(Value);
        }


        if (yDirection == 1)
        {
            lauchDirection.y = (Value);
        }


        if (yDirection == 2)
        {
            lauchDirection.y = 0f;
        }



        rb.velocity = lauchDirection;
    }

    

    void OnCollisionEnter(Collision hit)

    {
        // if hit the bounadries then the speed of direction is

        /*if(hit.gameObject.name == "TopBounds")
        {
            float speedInDirection = 0f;

            if (rb.velocity.x < 0f)
            {
                speedInDirection = -Value;
            }

            if (rb.velocity.x > 0f)
            {
                speedInDirection = Value;
            }

            rb.velocity = new Vector3(speedInDirection, -Value, 0f);


        }

        if (hit.gameObject.name == "BottomBounds")
        {
            float speedInDirection = 0f;

            if (rb.velocity.x < 0f)
            {
                speedInDirection = -Value;
            }

            if (rb.velocity.x > 0f)
            {
                speedInDirection = Value;
            }

            rb.velocity = new Vector3(speedInDirection, Value, 0f);
        }
*/
        //if we hit any of bat than the direction or speed is

        if(hit.gameObject.name == "Left_Bat")
        {

            

            if (transform.position.y - hit.gameObject.transform.position.y > 0.5)
            {
                Debug.Log("I'm in the if block ");
                rb.velocity = new Vector3(Value, Value, 0f);
            }

            else if (transform.position.y - hit.gameObject.transform.position.y < -0.5)
            {
                Debug.Log("I'm in the else if block ");
                rb.velocity = new Vector3(Value, -Value, 0f);
            }

            else
            {
                Debug.Log("I'm in the else  block ");
                rb.velocity = new Vector3(Value, 0f, 0f);
            }

            
        }

        if (hit.gameObject.name == "Right_Bat")
        {


            if (transform.position.y - hit.gameObject.transform.position.y > 0.5)
            {
                Debug.Log("I'm in the if block ");
                rb.velocity = new Vector3(-Value, Value, 0f);
            }

            else if (transform.position.y - hit.gameObject.transform.position.y < -0.5)
            {
                Debug.Log("I'm in the else if block ");
                rb.velocity = new Vector3(-Value, -Value, 0f);
            }

            else
            {
                Debug.Log("I'm in the else  block ");
                rb.velocity = new Vector3(-Value, 0f, 0f);
            }



        }
    }
}
