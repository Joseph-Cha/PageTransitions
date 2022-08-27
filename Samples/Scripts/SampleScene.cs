using PageTransitions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Paging.Instance.Init(PageName.PageA);
    }
}
