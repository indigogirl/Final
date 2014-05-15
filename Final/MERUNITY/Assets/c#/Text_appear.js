#pragma strict

var note : GUIText;
 
function Start (){
note.enabled = false; //You could also disable the GUI text in the inspector i wouldn't disable it on start if there is no reason
}
 
function OnTriggerEnter(other : Collider) 
{
 
    if(other.collider.tag == "Player") 
    {
    note.enabled = true;
    }
}
 
function OnTriggerExit () //No need to use col and collder here just ontriggerexit
{
note.enabled = false;
}