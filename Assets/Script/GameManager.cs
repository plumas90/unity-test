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
    public static Player_stats _player_stats = new();

    public static GameManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        //_player_stats = new Player_stats();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UIUpdate();
    }
    public void StatusOpen() 
    {
        StatusUI.SetActive(true);
    }
    public void StatusClose() 
    {
        StatusUI.SetActive(false);
    }
    private void UIUpdate()
    {
        PlayerGoldText.text = _player_stats.Gold.ToString();
        PlayerHPText.text = _player_stats.Hp.ToString();
        PlayerAtkText.text = _player_stats.Atk.ToString();
        PlayerDefText.text = _player_stats.Def.ToString();
        PlayerCriticalText.text = _player_stats.Critical.ToString();
    }
}
