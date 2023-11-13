using System.Collections;
using System.Collections.Generic;
using System;

public static class ContactAppEvent 
{
    public static event EventHandler ContactClosebook;
    public static void CloseBookFunction()
    {
        if (ContactClosebook != null)
        {
            ContactClosebook(new object(), new EventArgs());
        }
    }
}
