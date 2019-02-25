using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool CanWalk;
    public int Number = 11;
    public string Password;

    // Update is called once per frame
    void Update()
    {
        if (CanWalk)
        {
            print("True");
        }
        else
        {
            print(false);
        }

        if (Number >= 10)
        {
            print("Greater");
        }
        else
        {
            print("Lesser");
        }
//The below statement is an if-else efficiency condensation produced by JetBrains.
        print(Password == "OU812" ? "The password is correct." : "The Password is incorrect.");
    }
}
