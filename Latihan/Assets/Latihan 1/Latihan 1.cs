using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Saya Farhan Ramadhani Irsyad adalah Game Developer");
    }

    void FixedUpdate()
    {
        Debug.Log("Waktu untuk FixedUpdate: " + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Waktu untuk update: " + Time.deltaTime);
    }

    void LateUpdate()
    {
        Debug.Log("Waktu untuk LateUpdate: " + Time.deltaTime);
    }
}