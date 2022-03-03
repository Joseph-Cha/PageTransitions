using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PageTransitions
{
    public abstract class BasePage : MonoBehaviour
    {
        public virtual PageName PageName { get; }

        private void Awake() => Init();
        protected abstract void Init();

        public virtual void Show() => gameObject.SetActive(true);
        public virtual void Hide() => gameObject.SetActive(false);

        public void GoPage(PageName pageName)
        {
            Paging.Instance.GoPage(this, pageName);
        }

        public void BackPage() => Paging.Instance.BackPage(this);
    }
}
