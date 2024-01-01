using Singletoon;
using UnityEngine;

namespace Controller.Targets
{
    public class TargetManager : PublicInstance<TargetManager>
    {
        [SerializeField] private Transform[] targetTransform;
        [SerializeField] private Vector3[] targetPos;

        public Transform[] TargetTransform
        {
            get => targetTransform;
            set => targetTransform = value;
        }

        public Vector3[] TargetPos
        {
            get => targetPos;
            set => targetPos = value;
        }
    }
}
