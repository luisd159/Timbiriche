using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject Inner;
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        Inner.GetComponent<SpriteRenderer>().color = Color.blue;
    }
}
