using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;
public class LeerDato : MonoBehaviour
{
#if UNITY_IOS
        const string Test ="__Internal";
#else
    const string Test = "Test";
#endif
    [DllImport(Test)]
    private static extern System.IntPtr Reversar(string n);

    public TMP_InputField word; //Word to reverse
    public TMP_Text result; // Result final before reverse

    void Start()
    {
        
    }
    public void reverseText()
    {
        result.text= Marshal.PtrToStringAnsi(Reversar(word.text));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
