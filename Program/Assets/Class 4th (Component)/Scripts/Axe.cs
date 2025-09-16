using System;
using UnityEngine;

[System.Serializable]
public class Axe : Item
{
    public override void Activate()
    {
        Debug.Log("to cut down with an axe");
    }
}