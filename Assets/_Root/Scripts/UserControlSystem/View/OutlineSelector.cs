using UnityEngine;
using UnityEngine.UI;

public sealed class OutlineSelector : MonoBehaviour
{
    [SerializeField] private Outline[] _outlineComponents;

    private bool IsSelectedCache;

    void Start() => DisableOutline();

    public void SetSelected(bool IsSelected)
    {
        if (IsSelected == IsSelectedCache)
        {
            return;
        }

        if (IsSelected)
        {
            EnableOutline();
        }
        else
        {
            DisableOutline();
        }

        IsSelectedCache = IsSelected;
    }

    private void EnableOutline()
    {
        for (int i = 0; i < _outlineComponents.Length; i++)
        {
            _outlineComponents[i].enabled = true;
        }
    }

    private void DisableOutline()
    {
        for (int i = 0; i < _outlineComponents.Length; i++)
        {
            _outlineComponents[i].enabled = false;
        }
    }
}
