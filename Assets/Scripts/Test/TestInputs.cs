using System;
using System.Collections.Generic;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class TestInputs : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        private Vector3 localPlayableTargetPos;

        private void Start()
        {
            localPlayableTargetPos = PlayerManager.Instance.PlayeableTarget.localPosition;
         }
        
        public void GetInput(Vector2 touchDelta)
        {
            var _player = PlayerManager.Instance;
            
            _player.PlayeableTarget.transform.localPosition +=
                new Vector3(touchDelta.x * movementSpeed * Time.fixedDeltaTime,
                    touchDelta.y * movementSpeed * Time.fixedDeltaTime);
        }
        public void TapControl()
        {
            var _playerManager = PlayerManager.Instance;
            var _playerStats = PlayerStats.Instance;

            if (_playerManager.PlayerOnPole != PoleType.Endpole)
            {
                _playerManager.PathTween = transform.DOPath(_playerStats.PointLocation, 0.5f).SetEase(Ease.Linear).OnComplete(RoadVisible);

                if (_playerManager.PlayeableTarget.transform.localPosition.x > 0 ||
                    _playerManager.PlayeableTarget.transform.localPosition.y > 0)
                {
                    _playerManager.PlayeableTarget.transform.localPosition = localPlayableTargetPos;
                    _playerManager.LineRenderer.gameObject.SetActive(false);
                }
            }
            else
            {
             
                _playerManager.ProgressTween.Kill();
                ExpControl.ExpTypeControl(_playerStats, _playerManager);
                Debug.Log(_playerStats.SliderValues);

            }
        }
        private void RoadVisible()
        {
            PlayerManager.Instance.LineRenderer.gameObject.SetActive(true);
        }
    }
}