using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsSelector : MonoBehaviour
{

    private List<GameObject> pigs;
    private int selectionIndex = 2; //default index of player character

    void Start()
    {
        pigs = new List<GameObject>();
        foreach (Transform t in transform)
        {
            pigs.Add(t.gameObject);
            t.gameObject.SetActive(false);

        }

        pigs[selectionIndex].SetActive(true);
    }

    public void select(int index)
    {
        if (index == selectionIndex)
            return;
        if (index < 0 || index >= pigs.Count)
            return;
        pigs[selectionIndex].SetActive(false);
        selectionIndex = index;
        pigs[selectionIndex].SetActive(true);
    }

    void Update()
    {

    }
}

