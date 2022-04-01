using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    public string Scene;

    public void Awake()
    {
        PlayerPrefs.SetInt("tama�o", 3);
    }

    public void ChangeValue(float size)
    {
        this.GetComponent<TextMeshProUGUI>().text = "Tama�o: " + size + "x" + size;
    }

    public void GetTama�o(float size)
    {
        PlayerPrefs.SetInt("tama�o", (int)size);
    }

    private void OnMouseDown()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
