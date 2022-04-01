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
        PlayerPrefs.SetInt("tamaño", 3);
    }

    public void ChangeValue(float size)
    {
        this.GetComponent<TextMeshProUGUI>().text = "Tamaño: " + size + "x" + size;
    }

    public void GetTamaño(float size)
    {
        PlayerPrefs.SetInt("tamaño", (int)size);
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
