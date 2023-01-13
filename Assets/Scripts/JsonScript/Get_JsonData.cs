using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using SimpleJSON;
using System.IO;

public class Get_JsonData : MonoBehaviour
{
    JsonReferenceDataType jsonReference;

    string url = "http://ec2-3-236-80-43.compute-1.amazonaws.com/api1/v1/game/dummy/life-of-luxury";
    public bool testBool;
    public bool isActiveBool;
    public string[] testString;
    public List<string> winCombinationList;
    public List<string> winCombination1, winCombination2, winCombination3, winCombination4, winCombination5;
    public List<string> col1, col2, col3, col4, col5;
    public List<string> winRow1, winRow2, winRow3, winRow4, winRow5;
    public List<string> winRow6, winRow7, winRow8, winRow9, winRow10;
    public double price;
    public JSONNode node;
    public JSONArray lineArray;
    public JSONArray winCombinationArray;
    public JSONArray winCombinationArray2;

    public JSONObject winCombinationObject;

    public Root root;
    //public List<List<string>> linesGenerate;
    public List<string> linesGenerate;

    // Start is called before the first frame update
    void Start()
    {
        jsonReference = FindObjectOfType<JsonReferenceDataType>();
        StartCoroutine(Json_Request());
        //Debug.Log(rootInstance.success);
        //Debug.Log(jsonReference.jsonSucess);
    }

    private void Update()
    {
        //Debug.Log(request);
    }
    IEnumerator Json_Request()
    {
        UnityWebRequest request = UnityWebRequest.Post(url, "");
        //UnityWebRequest request = UnityWebRequest.Get(url);

        //request.downloadHandler = new DownloadHandlerBuffer();


        yield return request.SendWebRequest();
        if (request.error != null)
        {
            Debug.Log("Error can Fetch");
        }
        else
        {
            root = JsonConvert.DeserializeObject<Root>(request.downloadHandler.text);
            //JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(request.downloadHandler.text);

            lineArray = (JSONArray)node["lines_generated"];
            
            //var json = jsonResponse["lines_generated"].ToObject<List<Root>>();
            foreach (var item in lineArray)
            {
                for (int i = 0; i < lineArray.Value.Length; i++)
                {
                    linesGenerate.Add(item.Value[i]);
                    //linesGenerate.Add(json[i]);
                    //for (int j = 0; j < root.lines_generated[i].Count; j++)
                    //{
                    //linesGenerate.Add(root.lines_generated[i].ToString());
                    //}
                }
            }
            //node = JSON.Parse(request.downloadHandler.text);
            //winCombinationObject = (JSONObject)node["win_combination"];
            //winCombinationArray = (JSONArray)node["win_combination"]["0,1,2"]["lines"];
            //winCombinationArray2 = (JSONArray)node["win_combination"];
            //testString = (JSONArray)node["win_combination"];


            //foreach (var item in lineArray)
            //{
            //    for (int i = 0; i < item.Value.Count; i++)
            //    {
            //        if (i == 0)
            //        {
            //            col1.Add(item.Value[i]);
            //        }

            //        if (i == 1)
            //        {
            //            col2.Add(item.Value[i]);
            //        }
            //        if (i == 2)
            //        {
            //            col3.Add(item.Value[i]);
            //        }
            //        if (i == 3)
            //        {
            //            col4.Add(item.Value[i]);
            //        }
            //        if (i == 4)
            //        {
            //            col5.Add(item.Value[i]);
            //        }
            //    }
            //}

            //Debug.Log(winCombinationObject);

            //foreach (var combination in winCombinationObject)
            //{
            //    testString[0] = combination.ToString();
            //    Debug.Log(testString[0]);
            //    for (int j = 0; j < combination.Value.Count; j++)
            //    {
            //        winCombinationList.Add(combination.Value[j]);
            //        if (j == 0)
            //        {
            //            winCombination1.Add(combination.Value[j]);
            //        }

            //        if (j == 1)
            //        {
            //            winCombination2.Add(combination.Value[j]);
            //        }

            //        if (j == 2)
            //        {
            //            winCombination3.Add(combination.Value[j]);
            //        }

            //        if (j == 3)
            //        {
            //            winCombination4.Add(combination.Value[j]);
            //        }

            //        if (j == 4)
            //        {
            //            winCombination5.Add(combination.Value[j]);
            //        }
            //    }
            //}

            //foreach (var combinations in winCombinationArray)
            //{
            //    for (int j = 0; j < combinations.Value.Count; j++)
            //    {
            //        if (j == 0)
            //        {
            //            winRow1.Add(combinations.Value[j]);
            //        }

            //        if (j == 1)
            //        {
            //            winRow2.Add(combinations.Value[j]);
            //        }

            //        if (j == 2)
            //        {
            //            winRow3.Add(combinations.Value[j]);
            //        }

            //        if (j == 3)
            //        {
            //            winRow4.Add(combinations.Value[j]);
            //        }

            //        if (j == 4)
            //        {
            //            winRow5.Add(combinations.Value[j]);
            //        }

            //    }
            //}
            //foreach (var combinations2 in winCombinationArray2)
            //{
            //    for (int i = 0; i < combinations2.Value.Count; i++)
            //    {
            //        if(i == 0)
            //        {
            //            winRow6.Add(combinations2.Value[i]);
            //        }
            //    }
            //}



        }


    }


    //public static string[] AsStringArray(JSONArray arrayJson)
    //{
    //    string[] array = new string[arrayJson.Count];
    //    int index = 0;

    //    foreach(JSONNode node in arrayJson)
    //    {
    //        array[index] = (string)node.ToString();
    //        index += 1;
    //    }

    //    return array;
    //}



}
[System.Serializable]
public class _012
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _10110
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _1101
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _123
{
    public List<List<string>> lines;
    public double prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _234
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _345
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _456
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _567
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _678
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _789
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _8910
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class _91011
{
    public List<List<string>> lines;
    public int prize;
    public Combination combination;
    public string win_type;
}
[System.Serializable]
public class Combination
{
    [JsonProperty("2,1,0,1,2")]
    public List<int> _21012;

    [JsonProperty("1,0,0,0,1")]
    public List<int> _10001;

    [JsonProperty("2,1,1,1,2")]
    public List<int> _21112;

    [JsonProperty("2,2,2,2,2")]
    public List<int> _22222;

    [JsonProperty("1,1,1,1,1")]
    public List<int> _11111;

    [JsonProperty("0,0,0,0,0")]
    public List<int> _00000;
}
[System.Serializable]
public class Root
{
    public bool success;
    public List<List<string>> lines_generated;
    public WinCombination win_combination;
    public double price_used;
}
[System.Serializable]
public class WinCombination
{
    [JsonProperty("0,1,2")]
    public _012 _012;

    [JsonProperty("1,2,3")]
    public _123 _123;

    [JsonProperty("2,3,4")]
    public _234 _234;

    [JsonProperty("3,4,5")]
    public _345 _345;

    [JsonProperty("4,5,6")]
    public _456 _456;

    [JsonProperty("5,6,7")]
    public _567 _567;

    [JsonProperty("6,7,8")]
    public _678 _678;

    [JsonProperty("7,8,9")]
    public _789 _789;

    [JsonProperty("8,9,10")]
    public _8910 _8910;

    [JsonProperty("9,10,11")]
    public _91011 _91011;

    [JsonProperty("10,11,0")]
    public _10110 _10110;

    [JsonProperty("11,0,1")]
    public _1101 _1101;
}
