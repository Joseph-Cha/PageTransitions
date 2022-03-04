using PageTransitions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PageTransitions
{
    [CreateAssetMenu(fileName = "Page", menuName = "ScriptableObjects/SpawnPagesAsset", order = 1)]
    public class PagesAsset : ScriptableObject
    {
        public Transform ParentCanvas;
        public List<BasePage> Pages;
    }
}
