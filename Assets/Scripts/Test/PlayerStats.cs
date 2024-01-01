using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;

    private void Awake()
    {
        Instance = this;
    }
    
    [Header("Location Stat")]
    [SerializeField] private Vector3[] poleLocation = new Vector3[1];
    [SerializeField] private Vector3[] pointLocation = new Vector3 [1];
    public int poleId;
    
    [Header("EndGame Stat")]
    [SerializeField] private float sliderValues;
    [SerializeField] private ExpType expTypes;
    [SerializeField] private ExpType selectedExpTypes;
 

    public ExpType ExpTypes
    {
        get => expTypes;
        set => expTypes = value;
    }
    public ExpType SelectedExpTypes
    {
        get => selectedExpTypes;
        set => selectedExpTypes = value;
    }
    public float SliderValues
    {
        get => sliderValues;
        set => sliderValues = value;
    }
    
    public Vector3[] PointLocation
    {
        get => pointLocation;
        set => pointLocation = value;
    }

    
    public Vector3[] PoleLocation
    {
        get => poleLocation;
        set => poleLocation = value;
    }
}
