using UnityEngine;
using System.Collections;

public class coordinate : MonoBehaviour {

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	void Start () 
    {
	
	}

    /// <summary>
    /// 更新は、フレームごとに一度と呼ばれている
    /// </summary>
	void Update () 
    {
        Debug.Log(Camera.main.WorldToScreenPoint(transform.position));
	}
}
