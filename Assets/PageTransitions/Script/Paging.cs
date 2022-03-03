using UnityEngine;
using UnityEngine.Events;
using PageTransitions.Utils;
using System.Collections.Generic;

namespace PageTransitions
{
    public class Paging : Singleton<Paging>
    {
        [SerializeField]
        private PagesAsset PageAsset;

        private Dictionary<PageName, BasePage> pages = new Dictionary<PageName, BasePage>();
        private Stack<BasePage> pageStack { get; } = new Stack<BasePage>();
        private PageName currentPageName { get; set; }

        public void Init(PageName initPage)
        {
            pageStack.Clear();
            pages.Clear();

            Transform parent = GameObject.Instantiate<Transform>(PageAsset.ParentCanvas);
            parent.name = "Canvas";

            foreach (var page in PageAsset.Pages)
            {
                var pageObject = GameObject.Instantiate<BasePage>(page, parent);
                pageObject.name = page.name;
                pages.Add(pageObject.PageName, pageObject);

                if (pageObject.PageName == initPage)
                {
                    currentPageName = pageObject.PageName;
                    pageObject.Show();
                }
                else
                {
                    pageObject.Hide();
                }
            }
        }

        public void GoPage(BasePage currentPage, PageName nextPageName)
        {
            BasePage nextPage = FindPage(nextPageName);
            currentPageName = nextPageName;

            if (nextPage == null)
            {
                throw new System.NullReferenceException();
            }

            pageStack.Push(currentPage);
            nextPage?.Show();
            currentPage.Hide();
        }

        public void BackPage(BasePage currentPage)
        {
            if (pageStack.Count != 0)
            {
                BasePage PreviewPage = pageStack.Pop();
                this.currentPageName = PreviewPage.PageName;
                currentPage.Hide();
                PreviewPage.Show();
            }
        }

        public void BackPage(PageName currentPageName)
        {
            if (pageStack.Count != 0)
            {
                BasePage PreviewPage = pageStack.Pop();
                var currentPage = FindPage(currentPageName);
                this.currentPageName = PreviewPage.PageName;
                currentPage.Hide();
                PreviewPage.Show();
            }
        }

        public BasePage FindPage(PageName pageName)
        {
            if (pages.TryGetValue(pageName, out BasePage page))
            {
                return page;
            }
            return null;
        }

        public void ShowPage(PageName pageName)
        {
            if (pages.TryGetValue(pageName, out BasePage page))
            {
                page.Show();
            }
        }

        public void HidePage(PageName pageName)
        {
            if (pages.TryGetValue(pageName, out BasePage page))
            {
                page.Hide();
            }
        }

        public void ClearStack()
        {
            if (pageStack.Count < 0)
                return;
            pageStack.Clear();
        }

        public PageName GetCurrentPage() => currentPageName;
    }
}

