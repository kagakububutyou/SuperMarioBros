using UnityEngine;
using System.Collections;

public class TrackingCamera : MonoBehaviour {

    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Vector3 distance = new Vector3(0, 0, 0);
    [SerializeField]
    private Vector3 lookPoint = new Vector3(0, 0, 0);


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
        Move();
	}
    /// <summary>
    /// 追跡
    /// </summary>
    void Move()
    {
        this.transform.position = new Vector3(target.transform.position.x, distance.y, target.transform.position.z);

        //Vector3 lookVector = target.transform.position + lookPoint - this.transform.position;
        //this.transform.rotation = Quaternion.LookRotation(lookVector);
    }
}
