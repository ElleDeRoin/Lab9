using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target 
{
    private float speed;
    private float size;
    private int pointValue;
    
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetSize(float size)
    {
        this.size = size;
    }

    public void SetPointVal(int pointValue)
    {
        this.pointValue = pointValue;
    }
}
