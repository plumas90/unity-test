using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stats : MonoBehaviour
{
    public float Hp;
    public float Atk;
    public float Def;
    public float Critical;

    public float Gold;
    public Player_stats player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Player_stats() 
    {
        Hp = 100f; Atk = 35f; Def = 40f; Critical = 25f; Gold = 20000f;
    }
    public Player_stats(int hp, int atk, int def, int critical, int gold)
    {
        Hp= hp; Atk = atk; Def= def; Critical= critical; Gold= gold;
    }

}
