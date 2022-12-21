using UnityEngine;

public class OperatorenTest : MonoBehaviour
{
    public int a = 10;
    public int b = 5;
    public int c = 0;

    private void Start()
    {
        // arithmetic operators: add, subtract, multiply, divide, and modulo
        c = a + b;
        c = a - b;
        c = a * b;
        c = a / b;
        c = a % b;

        // logical operators: AND, OR, and NOT
        if (c > a && c > b) Debug.Log("c is the greatest value");

        if (c > a || c > b) Debug.Log("c is greater than a or b");
 
        if (!(c > a)) Debug.Log("c is not greater than a");

        // equality operators: equal to, not equal to
        if (a == b) Debug.Log("a is equal to b");

        if (a != b) Debug.Log("a is not equal to b");

        // compare operators: greater than, less than, greater than or equal to, less than or equal to
        if (a > b) Debug.Log("a is greater than b");

        if (a < b) Debug.Log("a is less than b");

        if (a >= b) Debug.Log("a is greater than or equal to b");

        if (a <= b) Debug.Log("a is less than or equal to b");


        // assignment operators: assign value, add and assign, subtract and assign, multiply and assign, divide and assign, modulo and assign
        a = c;
        a += c;
        a -= c;
        a *= c;
        a /= c;
        a %= c;
    }
}
