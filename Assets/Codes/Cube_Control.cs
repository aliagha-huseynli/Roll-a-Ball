using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Control : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
    }

}
