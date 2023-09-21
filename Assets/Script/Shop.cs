using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shop;

    public void ShopOpenBtn() 
    {
        shop.SetActive(true);
    }
    public void shopQuitBtn()
    {
        shop.SetActive(false);
    }
}
