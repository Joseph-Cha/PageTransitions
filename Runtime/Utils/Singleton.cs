using UnityEngine;

namespace PageTransitions.Utils
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance = null;
        public static T Instance
        {
            get
            {
                instance = (T)FindObjectOfType(typeof(T));

                if (instance == null)
                {
                    instance = new GameObject("@" + typeof(T).ToString()).AddComponent<T>();
                }
                return instance;
            }
        }
    }
}
