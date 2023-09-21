using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stats : MonoBehaviour
{
    public int Hp { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Critical { get; private set; }

    public int Gold { get; private set; }


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
        Hp = 100; Atk = 35; Def = 40; Critical = 25; Gold = 20000;
    }
    public Player_stats(int hp, int atk, int def, int critical, int gold)
    {
        Hp= hp; Atk = atk; Def= def; Critical= critical; Gold= gold;
    }

}
