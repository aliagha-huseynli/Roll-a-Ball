using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_Control : MonoBehaviour
{
    Rigidbody physics;
    public int velocity;
    int counter = 0;
    public int totalObjNumber;
    public Text counterText;
    public Text gameOverText;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, 0, v);

        physics.AddForce(vec*velocity);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            counter++;

            counterText.text = "Score: " + counter;

            if (counter == totalObjNumber)
            {
                gameOverText.text = "Game Over";
            }
        }
    }
}
