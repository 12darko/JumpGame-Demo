using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bezier : MonoBehaviour
{
    public  static Vector3[] Quadratic(Vector3 point1, Vector3 point2, Vector3 point3, int smoothness)
    {
        var _pointList = new List<Vector3>();

        for (var _ratio = 0f; _ratio <= 1; _ratio += 1.0f / smoothness) {
            var _tangentLineVertex1 = Vector3.Lerp(point1, point2, _ratio);
            var _tangentLineVertex2 = Vector3.Lerp(point2, point3, _ratio);
            var _bezierPoint = Vector3.Lerp(_tangentLineVertex1, _tangentLineVertex2, _ratio);

            _pointList.Add(_bezierPoint);
                
        }
        return _pointList.ToArray();
    }
}
