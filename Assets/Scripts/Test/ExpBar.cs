using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class ExpBar : MonoBehaviour
    {
        private void Start()
        {
            if (gameObject.activeSelf)
                SliderIncrease();
        }

        private void SliderIncrease()
        {
            var player = PlayerManager.Instance;

            player.ProgressTween = player.Slider.transform.GetChild(0).GetChild(0).GetComponent<Slider>()
                .DOValue(100, 0.4f).OnComplete(SliderDecrease);
        }

        private void SliderDecrease()
        {
            var player = PlayerManager.Instance;

            player.ProgressTween = player.Slider.transform.GetChild(0).GetChild(0).GetComponent<Slider>()
                .DOValue(0, 0.4f).OnComplete(SliderIncrease);
        }
    }
}