using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPole : MonoBehaviour
{
    public ExpType ExpType;
    public Vector3 ExpVector;
    private void Start()
    {
        ExpVector = transform.position;
    }
}
