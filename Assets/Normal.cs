using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : MonoBehaviour
{
    private Vector3 v1, v2;
    void Start()
    {
        v1 = new Vector3(1, 5, -7);
        v2 = new Vector3(2, 0, -6);
    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(Vector3.Cross(v1, v2));
        }
    }
}
