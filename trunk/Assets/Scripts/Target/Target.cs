using UnityEngine;
using System.Collections;

public abstract class Target: MonoBehaviour
{	
	protected Targets TARGET_ID;
	public Transform explosion;
	public AudioClip destroySound;
	public Vector3 leftFace = Vector3.down;
	public Vector3 rightFace = Vector3.down;
	
	public void createSound()
	{
		AudioSource.PlayClipAtPoint(destroySound, Camera.mainCamera.transform.position, GameStatus.soundVol);
	}
	
	public void createExplosion()
	{
		if(explosion != null)
			Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
		
	}
	
	abstract public void DoEffect(Arrow arrow);
}