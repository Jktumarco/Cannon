using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behave_2 : MonoBehaviour
{
    [SerializeField]
    float speed = 0.6f;
   
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed));          
    }
}
