using System;
using UnityEngine;

[System.Serializable]
public class Hammer : Item
{
    public override void Activate()
    {
        Debug.Log("Hit wiht a hammer");
    }
}
