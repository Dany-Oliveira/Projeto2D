using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    //only add this to books that actually unlock dialog
    [field: SerializeField] public string Id {  get; private set; }
    [field: SerializeField] public bool Hidden { get; private set; } = false;

    public void OnBookOpen()
    {
        BookManager.Instance.Unlock(Id);
    }

    private void OnBookRevealed(string id)
    {
        if(id == Id)
        {
            Hidden = false;
            BookManager.Instance.OnBookRevealed.RemoveListener(OnBookRevealed);
        }      
    }
}
