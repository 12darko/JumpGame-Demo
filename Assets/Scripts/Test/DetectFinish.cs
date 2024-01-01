using System;
using DG.Tweening;
using UnityEngine;

namespace Test
{
    public class DetectFinish : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var player = PlayerManager.Instance;

            var pole = other.gameObject.transform.GetComponent<TestPole>();

            if (pole != null)
            {
                pole.GetComponent<CapsuleCollider>().enabled = false;

                player.PlayerOnPole = pole.poleType;

                if (player.PlayerOnPole == PoleType.Endpole)
                {
                    //Finish
                    player.LineRenderer.enabled =false;
                    player.Slider.SetActive(true);
                    player.DetectCollider.GetComponent<SphereCollider>().radius = 200;
                }
            }
        }
    }
}