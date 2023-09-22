using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Progress;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPopup;
    [SerializeField] private GameObject slotsGrid; //모든 슬롯관리
    [SerializeField] private Player_stats player;

    //[SerializeField] private GameObject openInventory;
    //[SerializeField] private GameObject closeInventory;


    [SerializeField] private GameObject Infomation;
    [SerializeField] private GameObject equipBtn;
    [SerializeField] private GameObject unEquipBtn;
    public Image infomationImage;
    public TextMeshProUGUI infomationName;
    public TextMeshProUGUI infomationDescrption;
    public bool IsInfo;
    public static Inventory I= null;
    public int index;
    public Slot targetSlot;

    //슬롯들
    
    private Slot[] slots;
    //public Slot[] uiSlots;
    private void Awake()
    {
        if (null == I)
        {
            I = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        InventoryPopup.SetActive(false);
        slots = slotsGrid.GetComponentsInChildren<Slot>();
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].index = i;
            if (slots[i].item != null)
            {
                slots[i].item.Isequip = false;
            }
        }
        UpdateUI();
    }
    void Start()
    {
        //UpdateUI();
        //player = player.GetComponent<Player_stats>();



    }
    public void OpenIventoryBtn()
    {
        //UpdateUI();
        InventoryPopup.SetActive(true);
    }
    public void CloseInventoryBtn()
    {
        InventoryPopup.SetActive(false);
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

    public void AcquireItem(Item _item)
    {

        for (int i = 0; i < slots.Length; i++) //슬롯 개수만큼 반복문
        {
            if (slots[i].item == null) //빈공간찾아서 넣기
            {
                slots[i].AddItem(_item); // 슬롯의 additem 함수 호출(새 아이템 추가)
                return;
            }
        }

    }

    public void OpenInformation(Slot slot)
    {
        if (!IsInfo)
        {
            targetSlot = slot;
            Infomation.SetActive(true);
            infomationImage.sprite = targetSlot.item.itemImage;
            infomationName.text = targetSlot.item.name.ToString();
            infomationDescrption.text = targetSlot.item.itemDesc.ToString();

            if (targetSlot.item.Isequip)
            {
                unEquipBtn.SetActive(true);
                equipBtn.SetActive(false);
            }
            else
            {
                unEquipBtn.SetActive(false);
                equipBtn.SetActive(true);
            }
            IsInfo = true;
        }


    }
    public void CloseInformation()
    {
        unEquipBtn.SetActive(false);
        equipBtn.SetActive(false);
        Infomation.SetActive(false);
        IsInfo = false;
    }
    public void Equip()
    {
        player.Atk += targetSlot.item.atk;
        player.Def += targetSlot.item.Def;
        player.Hp += targetSlot.item.hp;

        targetSlot.Isequip.text = "E";
        targetSlot.item.Isequip = true;
        GameManager.Instance.PlayerStatUpdate();
        CloseInformation();
    }
    public void UnEquip()
    {
        player.Atk -= targetSlot.item.atk;
        player.Def -= targetSlot.item.Def;
        player.Hp -= targetSlot.item.hp;

        targetSlot.Isequip.text = string.Empty;
        targetSlot.item.Isequip = false;
        GameManager.Instance.PlayerStatUpdate();
        CloseInformation();
    }
}