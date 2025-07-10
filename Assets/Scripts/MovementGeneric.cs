using UnityEngine;

public class MovementGeneric : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool SchemeOne;
    public bool SchemeTwo;
    public bool SchemeThree;

    public bool FirstFrameW;

    // Update is called once per frame
    void Update()
    {
        // These three blocks of code change the state of our movement system
        // The player decided which type of movement system 
        if(Input.GetKey(KeyCode.Alpha1))
        {
            SchemeOne = true;
            SchemeTwo = false;
            SchemeThree = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SchemeOne = false;
            SchemeTwo = true;
            SchemeThree = false;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SchemeOne = false;
            SchemeTwo = false;
            SchemeThree = true;
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            SchemeOne = true;
            SchemeTwo = true;
            SchemeThree = true;
        } // End of this block of code

    } // End of Update()


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (SchemeOne)
            {
                // Move with Physics, smoothly
            }
            if (SchemeTwo)
            {
                // Move by just adding to position.y
            }
            if (SchemeThree)
            {
                if(FirstFrameW == false)
                {
                    // Move by giving a push with physics but only on first frame that W Key is down


                    // change this bool so that we do not enter this block of code next frame
                    FirstFrameW = true;

                }

            }
        }

        // Reset the bool for our SchemeThree first frame condition
        if(Input.GetKeyUp(KeyCode.W))
        {
            FirstFrameW = false;
        }

    } // END OF FixedUpdate()

} // END OF THE CLASS MovementGeneric
