using UnityEngine;

namespace LuisLabs.CoreDI
{
    public sealed class ServiceModule : MonoBehaviour
    {
        [SerializeField] private Module[] modules;

        private void Awake()
        {
            foreach (var module in modules)
            {
                module.Register();
            }
        }
    }
}