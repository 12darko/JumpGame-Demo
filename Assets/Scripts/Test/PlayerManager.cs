using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Test;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    [Header("Main Comp")]
    [SerializeField] private PoleType playerOnPole;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject slider;
    
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform playeableTarget;
    
    [SerializeField] private GameObject detectCollider;

    [SerializeField] private GameObject[] expStandsList;

    [SerializeField] private GameObject confettiEffect;
    
    [Header("Tween Comp")]
    [SerializeField]  private Tween pathTween;
    [SerializeField]  private Tween progressTween;


    public GameObject ConfettiEffect
    {
        get => confettiEffect;
        set => confettiEffect = value;
    }

    public GameObject[] ExpStandsList
    {
        get => expStandsList;
        set => expStandsList = value;
    }
 
    public GameObject DetectCollider
    {
        get => detectCollider;
        set => detectCollider = value;
    }
    public GameObject Slider
    {
        get => slider;
        set => slider = value;
    }


    public Transform PlayeableTarget
    {
        get => playeableTarget;
        set => playeableTarget = value;
    }

    public LineRenderer LineRenderer
    {
        get => lineRenderer;
        set => lineRenderer = value;
    }

    public PoleType PlayerOnPole
    {
        get => playerOnPole;
        set => playerOnPole = value;
    }
    
    public Transform PlayerTransform
    {
        get => playerTransform;
        set => playerTransform = value;
    }
    
    

    public Tween PathTween
    {
        get => pathTween;
        set => pathTween = value;
    }
    public Tween ProgressTween
    {
        get => progressTween;
        set => progressTween = value;
    }

}
