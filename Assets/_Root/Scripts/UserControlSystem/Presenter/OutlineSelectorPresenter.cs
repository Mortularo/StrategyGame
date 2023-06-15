using System;
using UnityEngine;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectableValue;

    private OutlineSelector[] _outlineSelectors;
    private ISelectable _currentSelectable;

    void Start()
    {
        _selectableValue.OnNewValue += OnSelected;        
    }

    private void OnSelected(ISelectable selectable)
    {
        if(_currentSelectable == selectable)
            return;
        
        SetSelected(_outlineSelectors, false);
        _outlineSelectors = null;

        if (selectable != null)
        {
            _outlineSelectors = (selectable as Component).GetComponentsInParent<OutlineSelector>();
            SetSelected(_outlineSelectors, true);
        }
        else
        {
            if (_outlineSelectors != null)
            {
                SetSelected(_outlineSelectors, false);
            }
        }
        _currentSelectable = selectable;
        static void SetSelected(OutlineSelector[] outlineSelectors, bool value)
        {
            if (outlineSelectors != null)
            {
                for (int i = 0; i < outlineSelectors.Length; i++)
                {
                    outlineSelectors[i].SetSelected(value);
                }
            }
        }
    }
}
