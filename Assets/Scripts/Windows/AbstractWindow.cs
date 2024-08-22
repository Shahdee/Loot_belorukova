using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWindow : IWindow
{
    public abstract EWindowType WindowType {get;}
    
    private readonly IWindowView _view;
    
    protected AbstractWindow(IWindowView view)
    {
        _view = view;
    }

    public void SetParent(Transform parent)
    {
        _view.SetParent(parent);
    }

    public void Open()
    {
        _view.Open();
    }

    public void Close()
    {
        _view.Close();
    }
    
}
