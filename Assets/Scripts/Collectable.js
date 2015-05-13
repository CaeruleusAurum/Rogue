#pragma strict
var pickUp = 1;
function OnTriggerEnter (info : Collider)
{
	if (info.name == "Player")
	{
		Score.currentScore += pickUp;
		Destroy(gameObject);
	}
}