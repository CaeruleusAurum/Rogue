#pragma strict
static var currentScore : int = 0;

var offsetY : float = 40;
var sizeX : float = 100;
var sizeY : float = 40;

function Awake ()
{
	currentScore = 0;
	
		
}

		
		
function OnGUI () {
	
	GUI.contentColor = Color.yellow;
	GUI.Box (new Rect (Screen.width/2-sizeX/2, offsetY, sizeX, sizeY), "Gold: " + currentScore);
	
	
}