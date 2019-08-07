using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemys
{
    public string NAME;
    public int HP;
    public ZOKUSEIS ZOKUSEI;
}

public enum ZOKUSEIS
{
    火,水
}