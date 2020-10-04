using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil a tambah b: " + c);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int Jumlah(int a, int b)
    {
        return a + b;
    }
}