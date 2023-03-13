using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            // +5
            GameManager.instance.ShowText("+" + pesosAmount + " money in bank account yey", 25, Color.yellow, transform.position, Vector3.up * 60, 1.5f);
        }
    }

}
