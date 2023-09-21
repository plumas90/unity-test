using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting.ReorderableList;

public class Slot : MonoBehaviour
{

    public Item item;
    public Image itemImage;
    public int index;
    //[SerializeField] private Inventory inventory;
    [SerializeField] public TextMeshProUGUI Isequip;
    //플레이어 정보
    [SerializeField]
    private Player_stats player;

    void Start()
    {
        //player = GameManager.Instance.player;
        if (item == null)
        {
            ClearSlot();
        }
        else
        {
            itemImage.sprite = item.itemImage;
        }

    }
    //아이템 획득
    public virtual void AddItem(Item _item)
    {
        item = _item;
        itemImage.sprite = item.itemImage;
    }


    private void ClearSlot()
    {
        item = null;
        itemImage = null;
        Isequip.text = string.Empty;
    }
    public void click()
    {
        if (item != null)
        {
            Inventory.I.OpenInformation(this);
        }
    }

}