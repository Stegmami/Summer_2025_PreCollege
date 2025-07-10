using UnityEngine;

public class ScoreOnTriggerEnter2D : MonoBehaviour
{
    // If we put this script in the enemyGO, then anytime a trigger2D collides with the enemyGO, the score will increase
        // The GO must have a Collider2D, Collider2D.IsTrigger must be true AND
        // There must be at least 1 Rigidbody2D in every collision. 
        // So for example, if I want collisions between my Friend and Enemy to call OnTriggerEnter2D()
        // Then either Friend or Enemy must have a Rigidbody2D


    // A reference to the GO in the scene that has our Scoreboard component
    GameObject ScoreboardGO;
    // a reference to an instance of the Scoreboard class
    public Scoreboard myScoreboard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // This is the C# way to assign a value to our variable.
        // We are using q Static method in the GameObject class 
        // FindWithTag() is the static method in the GameObject class
        ScoreboardGO = GameObject.FindWithTag("scoreboard");

        // GetComponent<T>() is also a method in the GameObject class, however, it is not static.
        // To use the GetComponent<T>() method we must first have a reference to a specific GameObject
        // That is, we need a reference to an instance of the GameObject class
        // ScoreboardGO is a an instance of the GameObject class!  Yay!
        myScoreboard = ScoreboardGO.GetComponent<Scoreboard>();

        // This is how we could write the same thing in one line.  
        // The . is how we (Me, you and the C#Compiler) know that we are going into the GameObject class
        myScoreboard = GameObject.FindWithTag("scoreboard").GetComponent<Scoreboard>();  
        
        // We print this here just to make sure we have made the reference successfully
        print(myScoreboard);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        myScoreboard.AddOneHitToScore();

        // This will print the name of the GO we collided with(triggered)
        print(other.gameObject.name);
    }

}
