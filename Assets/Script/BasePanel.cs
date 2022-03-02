using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BasePanel : MonoBehaviour
{
    public PageList PageList;
    public Button NextButton;
    public Button PreviouswButton;
    protected abstract GameObject FindPage();

    private void Awake() => InitEvent();

    private void InitEvent()
    {
        NextButton.onClick.AddListener(GoNextPage);
        PreviouswButton.onClick.AddListener(GoBackPage);
    }

    private void GoNextPage()
    {
        GameObject nextPage = FindPage();
        if (nextPage != null)
            Paging.Instance.GoNextPage(this.gameObject, nextPage);
    } 

    private void GoBackPage()
    {
        Paging.Instance.GoPreviewPage(this.gameObject);
    }

}
