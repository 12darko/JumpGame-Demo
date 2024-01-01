using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class TestMoveObs : MonoBehaviour
{
   public Vector3 rotateLocation;
   public float movingSpeed;
   public Ease moveEase;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DORotate(rotateLocation, movingSpeed).SetEase(moveEase).OnComplete(MoveMinus);
    }

    private void MoveMinus()
    {
        transform.DORotate(-rotateLocation, movingSpeed).SetEase(moveEase).OnComplete(Move);
    }
}