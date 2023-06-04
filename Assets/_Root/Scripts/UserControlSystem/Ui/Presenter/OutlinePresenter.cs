using PlasticGui.WorkspaceWindow.BrowseRepository;
using UnityEngine;
using UserControlSystem;

internal class OutlinePresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectedValue;
    [SerializeField] private GameObject _outlineBase;

    void Start()
    {
        _selectedValue.OnSelected += onClick;
        onClick(_selectedValue.CurrentValue);
    }
    private void onClick(ISelectable selected)
    {
        _outlineBase.SetActive(selected != null);
    }
}
