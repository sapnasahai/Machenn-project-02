using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToHide : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}

