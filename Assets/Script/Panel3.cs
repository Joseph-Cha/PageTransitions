using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel3 : BasePanel
{
    protected override GameObject FindPage()
    {
        return PageList.FindPage("4");
    }
}
