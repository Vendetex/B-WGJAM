using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {
    public static int IndexOf(object[] arr, object elem) {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == elem) {
                return i;
            }
        }
        return -1;
    }
}
