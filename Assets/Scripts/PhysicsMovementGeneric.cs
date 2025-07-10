using UnityEngine;

public class PhysicsMovementGeneric : MonoBehaviour
{
    // We are creating a class called PhysicsMovementGeneric
    // Our class inherits from the class MonoBehaviour

    // We need a reference to the Rigidbody2D instance
    // So we make a public variable in this class
    public Rigidbody2D MyRb2D;

    public float Speed;
    public Vector2 MaxSpeed;

    // Right now we just have an empty spot called Rb2D.
    // The C#Compiler knows that there will be a Rigidbody2D
    // However, the C#Compiler does not know *which* Rigidbdy2D we want to use
    // We need to point this instance of PhysicsMovementGeneric towards the instance of Rigidbody2D
    // There are two ways to do this pointing:
        // The C# way: look at the Start() method for how we make references in C#
        // The Unity Editor way: drag a the Game Object into the empty Rigidbody2D spot.
        // Then, if there is a Rigidbody2D on that game object, the C# Compiler will use that Ridgidbody2D


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Check whether we have a referencr to a rigidbody2D
        // If we do not have a reference to an instance of a Rb2D, then we say that
        // The value of MyRb2D is "null"
         if(MyRb2D == null)
        {
            // print("MyRb2D == null is true, we need a reference to a Rb2D");

            // We only get into this block of code if the conditional statement is true
            // so we must need a Rigidbody2D
            // Try making a reference using C#
            MyRb2D = GetComponent<Rigidbody2D>();

            // Now do anothr null check
            if (MyRb2D == null)
            {
                gameObject.AddComponent<Rigidbody2D>();
                // print(MyRb2D.gameObject.name + "GO must not have a Rigidbody2D component on it  We just added one right now!");

            }
            else
            {
                // print(MyRb2D.gameObject.name + "GO had a Rigidbody2D attached and now I have a reference to it");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // print("Update is called after all the Start() methods are called. Therefore, I should have a rigidbody2D now. proof:  "+MyRb2D);

        if (Input.GetKey(KeyCode.W))
        {
            // print("W Pressed");

            if (Mathf.Abs(MyRb2D.linearVelocity.y) < MaxSpeed.y)
            {
                MyRb2D.AddForce(Vector3.up * Speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            // print("S Pressed");

            if (Mathf.Abs(MyRb2D.linearVelocity.y) < MaxSpeed.y)
            {
                MyRb2D.AddForce(Vector3.down * Speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            // print("A Pressed");

            if(Mathf.Abs(MyRb2D.linearVelocity.x) < MaxSpeed.x)
            {
                MyRb2D.AddForce(Vector3.left * Speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            // print("D Pressed");

            if (Mathf.Abs(MyRb2D.linearVelocity.y) < MaxSpeed.y)
            {
                MyRb2D.AddForce(Vector3.right * Speed * Time.deltaTime);
            }
        }
    }
}
// NOTES:  Rigidbdy2D is a C# Class written by Unity  
// Like all C# Classes, it is a collection of Methods and Variables that we can use
// file:///C:/Program%20Files/Unity/Hub/Editor/6000.1.3f1/Editor/Data/Documentation/en/ScriptReference/Rigidbody2D.html

