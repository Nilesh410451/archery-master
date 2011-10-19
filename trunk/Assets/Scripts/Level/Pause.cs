using System;
using UnityEngine;

public class Pause: MonoBehaviour
{
	public GUISkin skin_large;
	public GUISkin skin_small;
	private bool show = false;
	public AudioClip confirmSound;
	public AudioClip openPauseSound;
	
	void OnGUI () {
		if(Screen.width > 900) {
			GUI.skin = skin_large;
		}
		else {
			GUI.skin = skin_small;
		}
		
		if (GUI.Button (new Rect (0.87f*Screen.width, 5, 0.13f*Screen.width, 0.05f*Screen.height), "Pause")) {
			show = !show;
			Time.timeScale = 1-Time.timeScale;
			AudioSource.PlayClipAtPoint(openPauseSound, new Vector3(0,18.3f,-33.6f), GameStatus.soundVol);
		}
		
		if(show){
			GUI.BeginGroup(new Rect(0.2f*Screen.width, 0.1f*Screen.height, 0.6f*Screen.width, 0.8f*Screen.height));
			GUI.Box(new Rect(0, 0, 0.6f*Screen.width, 0.8f*Screen.height), "PAUSE");
			if(GUI.Button(new Rect(0.05f*Screen.width, 0.3f*Screen.height, 0.5f*Screen.width, 0.11f*Screen.height),"Resume")){
				show = !show;
				Time.timeScale = 1-Time.timeScale;
				AudioSource.PlayClipAtPoint(confirmSound, new Vector3(0,18.3f,-33.6f), GameStatus.soundVol);
			}
			
			if(GUI.Button(new Rect(0.05f*Screen.width, 0.45f*Screen.height, 0.5f*Screen.width, 0.11f*Screen.height),"Retry")){
				Time.timeScale = 1-Time.timeScale;
				Loading.LOAD = true;
				AudioSource.PlayClipAtPoint(confirmSound, new Vector3(0,18.3f,-33.6f), GameStatus.soundVol);
				Application.LoadLevel("Level");
			}
			
			if(GUI.Button(new Rect(0.05f*Screen.width, 0.60f*Screen.height, 0.5f*Screen.width, 0.11f*Screen.height),"Main Menu")){
				Time.timeScale = 1-Time.timeScale;
				Loading.LOAD = true;
				AudioSource.PlayClipAtPoint(confirmSound, new Vector3(0,18.3f,-33.6f), GameStatus.soundVol);
				Application.LoadLevel("StartMenu");
			}
			GUI.EndGroup();
			
		}
			
	}

}


