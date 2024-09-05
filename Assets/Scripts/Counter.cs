using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public float ChargeAmount = 0;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeAmount += Time.deltaTime;

        }
    }
}
