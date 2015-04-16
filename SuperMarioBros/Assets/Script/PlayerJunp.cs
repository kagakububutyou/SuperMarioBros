using UnityEngine;
using System.Collections;
/// <summary>
/// ジャンプ
/// </summary>
public class PlayerJunp : MonoBehaviour {

    [SerializeField]
    private float Force = 0.0f;

    private float value = 0.0f;
    private float FlyingDistance = 0.0f;

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
        Junp();
	}
    /// <summary>
    /// ジャンプ
    /// </summary>
    void Junp()
    {
        value = Input.GetAxisRaw("Jump");
        FlyingDistance = value * Force * Time.deltaTime;

        transform.Translate(new Vector3(0, FlyingDistance, 0));

    }

}
