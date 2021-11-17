using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageList : MonoBehaviour
{
    public List<GameObject> Pages;

    public GameObject FindPage(string name)
    {
        return Pages.Find(go => go.name == name);
    }
}
