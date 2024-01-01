using DG.Tweening;
using UnityEngine;

namespace Test
{
    public class ExpControl : MonoBehaviour
    {
        public static void ExpTypeControl(PlayerStats player, PlayerManager playerManager)
        {
            if (player.SliderValues > 0 && player.SliderValues <= 25)
            {
                player.ExpTypes = ExpType.X2;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[0].transform.position, 10f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() => playerManager.ExpStandsList[0].transform.GetChild(0).gameObject.SetActive(true)
                    );
            }

            else if (player.SliderValues > 25 && player.SliderValues <= 35)
            {
                player.ExpTypes = ExpType.X4;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[1].transform.position, 10f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() => playerManager.ExpStandsList[1].transform.GetChild(0).gameObject.SetActive(true)
                    );
            }
            else if (player.SliderValues > 35 && player.SliderValues <= 45)
            {
                player.ExpTypes = ExpType.X6;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[2].transform.position, 2f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() => playerManager.ExpStandsList[2].transform.GetChild(0).gameObject.SetActive(true)
                    );
            }

            else if (player.SliderValues > 45 && player.SliderValues <= 55)
            {
                player.ExpTypes = ExpType.X8;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[3].transform.position, 2f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() => playerManager.ExpStandsList[3].transform.GetChild(0).gameObject.SetActive(true)
                    );
            }
            else if (player.SliderValues > 55 && player.SliderValues <= 75)
            {
                player.ExpTypes = ExpType.X16;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[4].transform.position, 2f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() => playerManager.ExpStandsList[4].transform.GetChild(0).gameObject.SetActive(true)
                    );
            }
            else if (player.SliderValues > 65 && player.SliderValues <= 85)
            {
                player.ExpTypes = ExpType.X32;
                player.SelectedExpTypes = player.ExpTypes;
                playerManager.PathTween = player.transform
                    .DOJump(playerManager.ExpStandsList[5].transform.position, 2f, 1, 1).SetEase(Ease.Linear)
                    .OnComplete(() =>
                        playerManager.ExpStandsList[5].transform.GetChild(0).gameObject.SetActive(true));
            }
            else
            {
                player.ExpTypes = ExpType.None;
            }
        }
    }
}