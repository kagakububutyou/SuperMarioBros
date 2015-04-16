using UnityEngine;
using System.Collections;
/// <summary>
/// スクロール
/// </summary>
public class TrackingCamera : MonoBehaviour {

    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Vector3 distance = new Vector3(0, 0, 0);

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
        //Tracking();
	}
    /// <summary>
    /// 追跡
    /// </summary>
    public void Tracking()
    {
        this.transform.position = 
            new Vector3(target.transform.position.x, distance.y, target.transform.position.z);

    }
}
