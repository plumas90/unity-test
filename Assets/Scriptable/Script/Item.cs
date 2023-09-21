using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//프로젝트 창에서 생성가능하게 만들기
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