using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerGoldText;
    public TextMeshProUGUI PlayerAtkText;
    public TextMeshProUGUI PlayerDefText;
    public TextMeshProUGUI PlayerHPText;
    public TextMeshProUGUI PlayerCriticalText;
    public GameObject StatusUI;
    public Player_stats player;

    public static GameManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        PlayerStatUpdate();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void StatusOpen() 
    {
        StatusUI.SetActive(true);
    }
    public void StatusClose() 
    {
        StatusUI.SetActive(false);
    }
    public void PlayerStatUpdate()
    {
        PlayerGoldText.text = player.Gold.ToString();
        PlayerHPText.text = player.Hp.ToString();
        PlayerAtkText.text = player.Atk.ToString();
        PlayerDefText.text = player.Def.ToString();
        PlayerCriticalText.text = player.Critical.ToString();
    }
}
