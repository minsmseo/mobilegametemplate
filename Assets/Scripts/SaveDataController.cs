using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

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
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();
        //save to userData what you want
        Debug.Log("Save");
        //bf.Serialize(stream, PlayerInfo); change to binary then more safety for gamer
        PlayerPrefs.SetString("PlayerInfo", Convert.ToBase64String(stream.GetBuffer()));
        stream.Close();
    }
    public void Load()
    {
        string data = PlayerPrefs.GetString("PlayerInfo");
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream stream = new MemoryStream(Convert.FromBase64String(data));
        user = (UserData)bf.Deserialize(stream);
    }
}
[SerializeField]
public struct UserData
{
    public string userName;
    //
}
