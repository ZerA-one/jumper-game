using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private UIInventoryController inventoryController;
    private int goldenCoin = 0;
    private int blueDiamond = 0;

    void Start()
    {
        inventoryController.SetGoldenCoinSlot(goldenCoin);
        inventoryController.SetBlueDiamondSlot(blueDiamond);
    }

    public void OnPickupItem(Item item)
    {
        if (item.getItemType() == Item.ItemType.BlueDiamond && item.isPickable())
        {
            blueDiamond++;
            inventoryController.SetBlueDiamondSlotWithAnimation(blueDiamond);
            item.PlayAnimationAndDestroy();
        }
        else if (item.getItemType() == Item.ItemType.GoldenCoin && item.isPickable())
        {
            goldenCoin++;
            inventoryController.SetGoldenCoinSlotWithAnimation(goldenCoin);
            item.PlayAnimationAndDestroy();

        }
    }
}
