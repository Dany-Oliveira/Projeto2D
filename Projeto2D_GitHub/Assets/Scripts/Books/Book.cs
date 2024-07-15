using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    //only add this to books that actually unlock dialog
    [field: SerializeField] public string Id {  get; private set; }

    public void OnBookOpen()
    {
        BookManager.Instance.Unlock(Id);
    }
}
