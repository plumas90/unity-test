using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shopslot : MonoBehaviour
{
    public Item item;
    public Image itemImage;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI gyrhk;
    public TextMeshProUGUI cost;
    // Start is called before the first frame update
    void Start()
    {
        itemImage.sprite = item.itemImage;
        Name.text=item.name;
        Description.text = item.itemDesc;
        cost.text = item.itemBuyCost.ToString();
        string gyrhktemp = string.Empty;
        if(item.atk != 0)
        {
            gyrhktemp += $"���ݷ� {item.atk}\n";
        }
        if (item.Def != 0)
        {
            gyrhktemp += $"���� {item.Def}\n";
        }
        if (item.hp != 0)
        {
            gyrhktemp += $"ü�� {item.hp}";
        }
        gyrhk.text = gyrhktemp;

    }

    public void BtnCheck()
    {
        Shop.Instance.BuyOpenBtn(item);
    }
}
