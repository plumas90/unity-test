using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shop;
    public GameObject BuyResult;
    public TextMeshProUGUI BuyResultText;
    public static Shop Instance;
    public Player_stats player;
    public Shopslot[] slots;
    [SerializeField] private GameObject slotsGrid;

    private void Start()
    {
        Instance = this;
        slots = slotsGrid.GetComponentsInChildren<Shopslot>();
        UpdateUI();
    }
    public void ShopOpenBtn() 
    {
        shop.SetActive(true);
    }
    public void shopQuitBtn()
    {
        shop.SetActive(false);
    }

    public void BuyOpenBtn(Item item) 
    {
        if (player.Gold >= item.itemBuyCost)
        {
            player.Gold-=item.itemBuyCost;
            Inventory.I.AcquireItem(item);
            BuyResultText.text = "구매 성공";
            GameManager.Instance.PlayerStatUpdate();
        }
        else
        {
            BuyResultText.text = "구매 실패";
        }
        BuyResult.SetActive(true);
    }
    public void BuyCloseBtn()
    {
        BuyResult.SetActive(false);
    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                slots[i].item.Isequip = false;
            }
        }
    }
}
