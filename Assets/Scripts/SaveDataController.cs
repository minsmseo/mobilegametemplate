using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataController : MonoBehaviour
{
    [SerializeField]
    private UserData user;
    
    protected void CreateUserData()
    {
        string name = "new user";
        //initailize userdata
        user = new UserData();
        user.userName = name;
    }
}
[SerializeField]
public struct UserData
{
    public string userName;
    //
}
