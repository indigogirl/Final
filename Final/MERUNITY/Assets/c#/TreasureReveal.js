#pragma strict

var chestSound: AudioClip;
var magicSound: AudioClip;
var treasure: GameObject;
var sparkles: GameObject;

function Start (){

sparkles.SetActive(false);
}

function OnTriggerEnter (col: Collider){

	if(col.gameObject.tag=="Player"){
		AudioSource.PlayClipAtPoint(chestSound,transform.position);
		AudioSource.PlayClipAtPoint(magicSound,transform.position);
		treasure.animation.Play("treasure_reveal");
		sparkles.SetActive(true);
		}
		}
