using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullObject : MonoBehaviour
{

    public static FullObject Instance;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

    }

    public int GetBoxCounter()
    {
        return GameObject.FindGameObjectWithTag("GameObject").transform.childCount - 1;
    }
}
