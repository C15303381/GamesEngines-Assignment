using UnityEngine;
using Random = System.Random;

public class ProceduralNumberGenerator { 
    public static int GetNextNumber() {
	
        Random r = new Random();
        int rInt = r.Next(0, 5);
        Debug.Log(rInt);

        return rInt;
    }

    public static int GetXPosition(int width)
    {
        Random r = new Random();
        int x = r.Next(width);
        Debug.Log(x);

        return x;
    }

    public static int GetZPosition(int width)
    {
        Random r = new Random();
        int z = r.Next(width);
        Debug.Log(z);

        return z;
    }

}
