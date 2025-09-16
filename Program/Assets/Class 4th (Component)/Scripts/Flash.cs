using System;
using UnityEngine;

[System.Serializable]
public class Flash : Item
{
    public override void Activate()
    {
        Debug.Log("Turn on the flash");
    }
}
