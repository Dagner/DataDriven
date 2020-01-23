using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;



public class ReadTextFile : MonoBehaviour
{
    // Start is called before the first frame update
    string assetsPath;
    string fileName;
    string path;
    public GameObject txtMesh;
    
    void Start()
    {
        TextMeshProUGUI txtM = txtMesh.GetComponent<TextMeshProUGUI>();
       
        
        assetsPath = Application.streamingAssetsPath;
        fileName = "HolaMundo.txt";
        path = assetsPath +"/" + fileName;
        print(path);
        StreamReader sr = new StreamReader(path);
        string rawText = sr.ReadToEnd();
        sr.Close();

        print(rawText);
        parseText(rawText);
        txtM.text = rawText;
        
    }

    void parseText(string txt)
    {
        string [] lines = txt.Split('\n');
        int i = 0;
        foreach(string line in lines)
        {
            print(i+":"+line);
            i++;
        }






        string num = "5";
        int n = int.Parse(num);
        n = n + 6;
        print(n);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
