﻿using UnityEngine;

public class Colliders : MonoBehaviour
{
    public int index;
    BoxCollider boxCollider;
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        index = transform.GetSiblingIndex();
    }

   
    public void HitCollider(float damage)
    {
        if (boxCollider.size.y - damage > 0.0f)
        {
            boxCollider.size = new Vector3(boxCollider.size.x, boxCollider.size.y - damage, boxCollider.size.z);
        }
        else
            Destroy(this);
    }
}
