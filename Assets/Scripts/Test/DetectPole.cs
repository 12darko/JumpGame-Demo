using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace Test
{
    public class DetectPole : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var pole = other.gameObject.transform.GetComponent<TestPole>();

            if (pole != null)
            {
                if (pole.poleType != PoleType.Startpole)
                {
                    PlayerStats.Instance.PoleLocation[0] = pole.transform.position;
                }
            }
        }

        
        private void Update()
        {
            var playerManager = PlayerManager.Instance;
            var playerStats = PlayerStats.Instance;

            if (playerStats.PoleLocation != null)
            {
                var _points = Bezier.Quadratic(playerManager.transform.position,
                    playerManager.PlayeableTarget.position, playerStats.PoleLocation[0], 12);

                playerManager.LineRenderer.positionCount = _points.Length;
                playerManager.LineRenderer.SetPositions(_points);

                playerStats.PointLocation = _points;

            }
            else
            {
                //Restart The game

                Destroy(playerManager.LineRenderer);
            }
        }
    }
}