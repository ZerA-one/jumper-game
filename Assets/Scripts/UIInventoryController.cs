using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInventoryController : MonoBehaviour
{
    [SerializeField] private GameObject goldenCoinSlot;
    [SerializeField] private GameObject blueDiamondSlot;

    public void SetGoldenCoinSlot(int amout)
    {
        goldenCoinSlot.GetComponentInChildren<TMP_Text>().text = amout.ToString();
    }

    public void SetBlueDiamondSlot(int amout)
    {
        blueDiamondSlot.GetComponentInChildren<TMP_Text>().text = amout.ToString();
    }

    public void SetBlueDiamondSlotWithAnimation(int amout)
    {
        blueDiamondSlot.GetComponent<Animator>().SetTrigger("GetBlueDiamond");
        SetBlueDiamondSlot(amout);
    }

    public void SetGoldenCoinSlotWithAnimation(int amount)
    {
        goldenCoinSlot.GetComponent<Animator>().SetTrigger("GetGoldenCoin");
        SetGoldenCoinSlot(amount);
    }

    public void SetBlueDiamondSlot(int amount, bool playAnimation = false)
    {
        blueDiamondSlot.GetComponentInChildren<TMP_Text>().text = amount.ToString();
        if (playAnimation)
        {
            blueDiamondSlot.GetComponent<Animator>().SetBool("Pop", true);
        }
    }
}
