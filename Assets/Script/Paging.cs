using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paging
{
    private static Paging instance;
    public static Paging Instance => instance ??= new Paging();
    Stack<GameObject> panels = new Stack<GameObject>();

    public void GoNextPage(GameObject currentPage, GameObject nextPage)
    {
        panels.Push(currentPage);
        SetPageDeactive(currentPage);
        nextPage.SetActive(true);
        // if (panels.Count > 0)
        // {
        //     if (nextPage == panels.Peek())
        //         return;
        //     panels.Push(currentPage);
        //     SetPageDeactive(currentPage);
        //     nextPage.SetActive(true);
        // }
        // else
        // {
        //     panels.Push(currentPage);
        //     SetPageDeactive(currentPage);
        //     nextPage.SetActive(true);
        // }
    }

    public void GoPreviewPage(GameObject currentPage)
    {
        if (panels.Count != 0)
        {
            GameObject PreviewPage = panels.Pop();
            SetPageDeactive(currentPage);
            PreviewPage.SetActive(true);
        }
    }

    private void SetPageDeactive(GameObject page) => page.SetActive(false);
}
