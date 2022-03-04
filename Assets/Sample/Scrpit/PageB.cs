using PageTransitions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageB : BasePage
{
    public override PageName PageName => PageName.PageB;

    [SerializeField]
    private Button GoPageA_Button;
    [SerializeField]
    private Button GoPageC_Button;
    [SerializeField]
    private Button Back_Button;

    protected override void Init()
    {
        GoPageA_Button.onClick.AddListener(() => GoPage(PageName.PageA));
        GoPageC_Button.onClick.AddListener(() => GoPage(PageName.PageC));
        Back_Button.onClick.AddListener(() => BackPage());
    }
}
