using System.Collections;
using System.Collections.Generic;
using System;

public static class AppEvent 
{
    public static event EventHandler Closebook;
    public static void CloseBookFunction()
    {
        if (Closebook != null)
        {
            Closebook(new object(), new EventArgs());
        }
    }
}
