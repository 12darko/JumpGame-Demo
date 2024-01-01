using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Test;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var _player = other.transform.GetComponent<TestInputs>();
        
        if (_player)
        {
            PlayerManager.Instance.PathTween.Kill();

            PlayerStats.Instance.PoleLocation = null;
        }
    }
}
