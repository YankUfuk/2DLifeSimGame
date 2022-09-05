using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanNpc1 : NPC
{
    public void Awake()
    {
        MovementOnX();
        flipOnX();
        getComponents();

    }
}
