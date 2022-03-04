# PageTransitions

Unity UGUI에서 사용 가능한 Page Transition System

## 핵심 기능

![Alt Text](https://i.imgur.com/vkhHQSL.gif)

사용자가 방문했던 Page를 다시 돌아올 수 있도록 구현

## 사용 방법

### 사전 준비

1. SpawnPagesAsset 생성 (Assets -> Create -> ScriptableObjects -> SpawnPagesAsset 클릭)
2. Page UI 작업 후 해당 `Page Script` 생성
3. `Page Script`에 `BasePage` 상속 및 구현
    - `Page` 이름 Enum에 추가
    - `Init`에 UI Callback 추가
4. Page 이동 및 뒤로가기 구현 방법
    ``` C#
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
    ```
5. 해당 페이지 `GameObject`를 `Prefab`으로 만든 후 앞서 만든 `PageAsset`에 추가
6. 각 페이지에 대해서 위 작업을 반복
7. `PageAsset`에 추가된 페이지들이 자동으로 생성시키기 위해 초기화 메서드 호출
    ``` C#
    using PageTransitions;
    using UnityEngine;

    public class SampleScene : MonoBehaviour
    {
        void Start()
        {
            Paging.Instance.Init(PageName.PageA);
        }
    }
    ```

