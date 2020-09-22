using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewChange
{
    private string type;
    private GameObject item;
    private Transform previousPos;

    public NewChange(string type, GameObject item, Transform pos)
    {
        this.type = type;
        this.item = item;
        previousPos = pos;
    }

    public NewChange(string type, GameObject item)
    {
        this.type = type;
        this.item = item;
    }

    public Transform GetPos()
    {
        return previousPos;
    }

    public string GetType()
    {
        return type;
    }

    public GameObject GetItem()
    {
        return item;
    }
}
