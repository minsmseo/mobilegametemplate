using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    //Controller to Manage UI
    public static UIController instance;

    [SerializeField]
    private Button MenuButton;
    private Button ExitButton;
    [SerializeField]
    private GameObject Menu;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    public void OpenMenu()
    {
        Menu.gameObject.SetActive(true);
    }
    public void CloseMenu()
    {
        Menu.gameObject.SetActive(false);
    }
    public void ExitProgram()
    {
        Application.Quit();
    }
}
