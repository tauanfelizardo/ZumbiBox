﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

[System.Serializable]
public class Level //A Single Level
{
    public List<string> m_Rows = new List<string>();

    public int Height { get { return m_Rows.Count; } }
    public int Width
    { 
        get 
        { 
            int maxLength = 0;
            foreach(var r in m_Rows)
            { 
                if(r.Length > maxLength) maxLength = r.Length;
            }
            return maxLength;
        }
    }
}



public class Levels : MonoBehaviour
{
    public string filename;
    public string filenameNew;
    public List<Level> m_Levels;

    public bool is_tutorial;
    

    void Awake()
    { 
        // tutorial = GetComponent<Fluxo>();
        TextAsset textAsset; 
        textAsset = (TextAsset)Resources.Load(filename);
            if(!textAsset)
            { 
                Debug.Log("Tutorial: " + filename + ".txt não existe!");
                return;
            }
            else
            { 
                Debug.Log("Tutorial importado");
            }  
        string completeText = textAsset.text;
        string[] lines;
        lines = completeText.Split(new string[] { "\n"}, System.StringSplitOptions.None);
        m_Levels.Add(new Level());
        for (long i=0; i<lines.LongLength; i++)
        { 
            string line = lines[i];
            if(line.StartsWith(";"))
            { 
                Debug.Log("Novo Level Adicionado");
                m_Levels.Add(new Level());
                continue;
            }
            m_Levels[m_Levels.Count - 1].m_Rows.Add(line); //Always adding level rows to last level in list of levels
            
        }
    }
}
