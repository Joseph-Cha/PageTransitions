using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel1 : BasePanel
{
    protected override GameObject FindPage()
    {
        return PageList.FindPage("2");
    }
}
