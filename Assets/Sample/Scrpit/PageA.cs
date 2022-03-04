using PageTransitions;
using UnityEngine;
using UnityEngine.UI;

public class PageA : BasePage
{
    public override PageName PageName => PageName.PageA;

    [SerializeField]
    private Button GoPageB_Button;    
    [SerializeField]
    private Button GoPageC_Button;
    [SerializeField]
    private Button Back_Button;

    protected override void Init()
    {
        GoPageB_Button.onClick.AddListener(() => GoPage(PageName.PageB));
        GoPageC_Button.onClick.AddListener(() => GoPage(PageName.PageC));
        Back_Button.onClick.AddListener(() => BackPage());
    }
}
