using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private GameObject _target   = null;    // ロックオンしたターゲット
	private float      _speed    = 6.0f;    // 1秒間に進む距離
	private float      _rotSpeed = 180.0f;  // 1秒間に回転する角度
	
	public GameObject Target
	{
		set { _target = value; }
		get { return _target; }
	}
	
	// Update is called once per frame
	void Update()
	{
		if (_target == null)
		{
			return;
		}
		
		// ターゲットまでの角度を取得
		Vector3    vecTarget  = _target.transform.position - transform.position; // ターゲットへのベクトル
		Vector3    vecForward = transform.TransformDirection(Vector3.forward);   // 弾の正面ベクトル
		float      angleDiff  = Vector3.Angle(vecForward, vecTarget);            // ターゲットまでの角度
		float      angleAdd   = (_rotSpeed * Time.deltaTime);                    // 回転角
		Quaternion rotTarget  = Quaternion.LookRotation(vecTarget);              // ターゲットへ向けるクォータニオン
		if (angleDiff <= angleAdd)
		{
			// ターゲットが回転角以内なら完全にターゲットの方を向く
			transform.rotation = rotTarget;
		}
		else
		{
			// ターゲットが回転角の外なら、指定角度だけターゲットに向ける
			float t = (angleAdd / angleDiff);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotTarget, t);
		}
		
		// 前進
		transform.position += transform.TransformDirection(Vector3.forward) * _speed * Time.deltaTime;
	
	}

	void OnCollisionEnter(Collision Col)
	{
		if(Col.gameObject.tag == "Enemy")
		{
			Destroy (Col.gameObject);
		}
	}

}