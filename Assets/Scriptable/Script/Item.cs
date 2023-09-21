using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//������Ʈ â���� ���������ϰ� �����
[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{


    public string itemName; 
    public ItemType itemType;
    public Sprite itemImage; 
    public GameObject itemPrefab; 
    public float itemBuyCost;

    public float atk;
    public float Def;
    public float hp;
    public bool Isequip;

    [TextArea] 
    public string itemDesc;

    public enum ItemType 
    {
        Equipment,
    }


}