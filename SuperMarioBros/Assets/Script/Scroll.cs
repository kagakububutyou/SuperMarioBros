using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

    [SerializeField]
    private GameObject target;

    private Vector3 ScreenPoint;

    private TrackingCamera trackingCamera;

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
        main();
	}
    
    void main()
    {
        ScreenPoint = Camera.main.WorldToScreenPoint(target.transform.position);

        Debug.Log(ScreenPoint);

        if (ScreenPoint.x >= Screen.width/2)
        {
            trackingCamera = GetComponent<TrackingCamera>();

            trackingCamera.Tracking();

        }
    }
}
