using PageTransitions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageC : BasePage
{
    public override PageName PageName => PageName.PageC;

    [SerializeField]
    private Button GoPageA_Button;

    protected override void Init()
    {
        GoPageA_Button.onClick.AddListener(() => GoPage(PageName.PageA));
    }


}
