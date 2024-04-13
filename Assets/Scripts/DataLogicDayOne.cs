using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class DataLogicDayOne : MonoBehaviour
{
    [SerializeField] Object[] newAnimals;
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.streamingAssetsPath + "/possibilities.json";
        string jsonString = File.ReadAllText(path);
        Classes.Possibilites possibilities = JsonConvert.DeserializeObject<Classes.Possibilites>(jsonString);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
