using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    //only add this to books that actually unlock dialog
    [field: SerializeField] public string Id {  get; private set; }
    [field: SerializeField] public bool Hidden { get; private set; } = false;

    //update scripted execution order so bookmanager runs before book
    /*private void Awake()
    {
        if (Hidden)
        {
            BookManager.Instance.OnBookRevealed.AddListener(OnBookRevealed);
        }     
    }*/


    //Called by button event
    public void OnBookOpen()
    {
       /* if (Hidden)
        {
            return;
        }*/

        BookManager.Instance.Unlock(Id);
        print("book id: " + Id);
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
