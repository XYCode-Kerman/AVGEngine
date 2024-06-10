using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

// 用于解析 ADF 文件
public class ADFParser : MonoBehaviour
{
    public ADF adf;

    void Awake()
    {
        var adfile = Resources.Load<TextAsset>("adf");
        adf = JsonConvert.DeserializeObject<ADF>(adfile.text);
    }
}
