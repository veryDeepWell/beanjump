using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMove : MonoBehaviour
{
    public Transform orientation;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.rotation = orientation.rotation;
    }
}
