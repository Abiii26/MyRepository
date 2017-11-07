using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    enum States { cell, sheet_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
        stairs_0, floor, floor_hairclip, closet_door, corridor_1, stairs_1, in_closet,
        corridor_2, corridor_2_busted, stairs_2, corridor_3, courtyard}

    public Text myText;
    States myState;

	// Use this for initialization
	void Start () {

        myState = States.cell;
        
	}
	
	// Update is called once per frame
	void Update () {
       
        if(myState == States.cell)
        {
            Cell();
        }
        else if (myState == States.sheet_0)
        {
            Sheets_0();
        }
        else if (myState == States.lock_0)
        {
            Lock_0();
        }
        else if (myState == States.mirror)
        {
            Mirror();
        }
        else if (myState == States.cell_mirror)
        {
            Cell_Mirror();
        }
        else if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myState == States.lock_1)
        {
            Lock_1();
        }
        else if (myState == States.corridor_0)
        {
            Corridor_0();
        }
        else if (myState == States.stairs_0)
        {
            Stairs_0();
        }
        else if (myState == States.floor)
        {
            Floor();
        }
        else if (myState == States.floor_hairclip)
        {
            Floor_Hairclip();
        }
        else if (myState == States.closet_door)
        {
            Closet_Door();
        }
        else if (myState == States.corridor_1)
        {
            Corridor_1();
        }
        else if (myState == States.stairs_1)
        {
            Stairs_1();
        }
        else if (myState == States.in_closet)
        {
            In_Closet();
        }
        else if (myState == States.corridor_2)
        {
            Corridor_2();
        }
        else if (myState == States.corridor_2_busted)
        {
            Corridor_2_Busted();
        }
        else if (myState == States.stairs_2)
        {
            Stairs_2();
        }
        else if (myState == States.corridor_3)
        {
            Corridor_3();
        }
        else if (myState == States.courtyard)
        {
            Courtyard();
        }
        
    }

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape. " +
            "There are some dirty sheets on the bed, a mirror on the wall, " +
            "and the door is locked from the outside.\n\n" +
            "Press S to view the sheets, M to view the mirror and L to view " +
            "the Lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheet_0;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }

    }

    void Sheets_0()
    {
        myText.text = "These sheets are very dirty! I guess you would expect that " +
            "from a prison. Hopefully they are changed soon!" +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
            "combination is. You wish you could somehow see where the dirty fingerprints " +
            "were." +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void Mirror()
    {
        myText.text = "That dirty old mirror on the wall seems loose!" +
            "\n\nPress T to take mirror, or R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void Cell_Mirror()
    {
        myText.text = "You are still in your cell and you STILL want to escape!" +
            "There are still some dirty sheets on the bed and the cell door which is firmly " +
            "locked." +
            "\n\nPress S to view the sheets, or L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void Sheets_1()
    {
        myText.text = "Holding in a mirror in your hand, won't make the sheets look any better and cleaner!" +
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror throught the bars, and turn it round to see the lock." +
            "You can now see the fingerprints on the buttons. You press the buttons, and hear a click!!" +
            "\n\nPress O to open, or R to return back to the cell.";

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void Corridor_0()
    {
        myText.text = "You are finally FREE...from your CELL. Did you really think it was going to be that EASY..." +
            "Where will you be going now?" +
            "\n\nPress Up Arrow to walk up the stairs, Press F to look at the floor, or Press D to look at the closet door.";

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myState = States.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.closet_door;
        }
    }

    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. You realise it's not break time, " +
            "and you'll be caught immediately. You slither back down the stairs and reconsider." +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
        
    }

    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip." +
            "\n\nPress T to take the hairclip or Press R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.floor_hairclip;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    
    void Floor_Hairclip()
    {
        myText.text = "You take the hairclip but wonder what to do with it. Who knows " +
            "maybe it can be used somewhere." +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }

    void Closet_Door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?" +
        "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?" +
        "\n\nPress P to pick the lock with the hairclip or Press R to return .";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.in_closet;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.floor;
        }
    }

    void Stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
        "confidence to walk out into a courtyard surrounded by armed guards!" +
        "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }

    }

    void In_Closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up." +
           "\n\nPress W to wear the uniform or Press R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.corridor_3;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }

    }

    void Corridor_2()
    {
        myText.text = "You returned to the corridor without wearing the uniform. Unlucky for " +
            "you, you are faced with three armed guards who instantly run towards you. Think fast!" +
            "\n\nPress the Up Arrow to run up the stairs or Press S to stay still.";

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myState = States.stairs_2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.corridor_2_busted;
        }

    }

    void Corridor_2_Busted()
    {
        myText.text = "You decided to stay still and let the armed guards get to you. You were " +
            "forced down to the ground, handcuffed and dragged back to your cell. Guess your escape plan didn't " +
            "work...YOU GOT BUSTED!" +
            "\n\nPress P to Play Again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }

    void Stairs_2()
    {
        myText.text = "You rush up the stairs in hopes of surviving but because of trying to escape " +
            "you got shot multiple times in the back...YOU ARE DEAD!" +
            "\n\nPress P to Play Again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }

    void Corridor_3()
    {
        myText.text = "You're standing in the corridor, now convincingly dressed as a cleaner." +
        "You strongly consider the run for freedom." +
        "\n\nPress C to go to the courtyard or Press R to return to the closet.";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.courtyard;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.in_closet;
        }
    }

    void Courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. The guard tips his hat at you as " +
        "you waltz past, claiming your freedom. You heart races as you walk into the sunset." +
        "\n\nPress P to Play Again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }

}
