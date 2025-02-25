﻿/// <summary>
/// Handles parsing and execution of console commands, as well as collecting log output.
/// Copyright (c) 2014-2015 Eliot Lash
/// </summary>
using UnityEngine;

using System;
using System.Collections.Generic;
using System.Text;

public delegate void CommandHandler(string[] args);

public class ConsoleController
{

    #region Event declarations
    // Used to communicate with ConsoleView
    public delegate void LogChangedHandler(string[] log);
    public event LogChangedHandler logChanged;

    public delegate void VisibilityChangedHandler(bool visible);
    public event VisibilityChangedHandler visibilityChanged;
    #endregion

    /// <summary>
    /// Object to hold information about each command
    /// </summary>
    class CommandRegistration
    {
        public string command { get; private set; }
        public CommandHandler handler { get; private set; }
        public string help { get; private set; }

        public CommandRegistration(string command, CommandHandler handler, string help)
        {
            this.command = command;
            this.handler = handler;
            this.help = help;
        }
    }

    /// <summary>
    /// How many log lines should be retained?
    /// Note that strings submitted to appendLogLine with embedded newlines will be counted as a single line.
    /// </summary>
    const int scrollbackSize = 20;

    Queue<string> scrollback = new Queue<string>(scrollbackSize);
    List<string> commandHistory = new List<string>();
    Dictionary<string, CommandRegistration> commands = new Dictionary<string, CommandRegistration>();

    public string[] log { get; private set; } //Copy of scrollback as an array for easier use by ConsoleView

    const string repeatCmdName = "!!"; //Name of the repeat command, constant since it needs to skip these if they are in the command history

    public ConsoleController()
    {
        //When adding commands, you must add a call below to registerCommand() with its name, implementation method, and help text.
        /*registerCommand("babble", babble, "Example command that demonstrates how to parse arguments. babble [word] [# of times to repeat]");
        registerCommand("echo", echo, "echoes arguments back as array (for testing argument parser)");*/
        registerCommand("help", help, "Print this help. Add a command as an argument and get the explanation for that specific command");
        registerCommand("resetoptions", resetPrefs, "Reset player options");
        registerCommand("noclip", noclip, "Toggles No Clip");
        registerCommand("godmode", godmode, "Switches godmode");
        registerCommand("playsub", playsub, "Plays the specified subtitle from the specified table. Usage: playsub [identifier] [table]   (WITHOUT THE BRACKETS)");
        registerCommand("playvoicesub", playvoicesub, "Plays the specified voice subtitle from the specified character. Usage: playsub [character] [identifier]   (WITHOUT THE BRACKETS)");
        registerCommand("playtuto", playtuto, "Shows the specified tutorial card. Usage: playtuto [identifier] (NO BRACKETS)");
        registerCommand("subtitlecheck", subcheck, "Adds missing subtitles from the current language pack");
        registerCommand("give", give, "Gives you the specified item.");
        registerCommand("gopocket", goPocket, "Tests the Pocket Dimension");
        //registerCommand("safeplace", safeplace, "Tests the world change function");
        //registerCommand("safereturn", safereturn, "Tests the world return function");
        registerCommand("goto", teleportCoord, "Teleports to the x and y coordinate");
        registerCommand("teleport", teleportRoom, "Teleports to room with this name");
        registerCommand("spawn106", spawn106, "Spawns SCP-106 at the center of the current room");
        registerCommand("spawn173", spawn173, "Spawns SCP-173 at the center of the current room");
        registerCommand("spawn049", spawn049, "Spawns SCP-049 at the center of the current room");
        registerCommand("spawn096", spawn096, "Spawns SCP-096 at the center of the current room");
        registerCommand("spawn513", spawn513, "Activates SCP-513");
        registerCommand("health", sethealth, "Sets the player current health [0 - 100]");
        registerCommand(repeatCmdName, repeatCommand, "Repeat last command.");
    }

    void registerCommand(string command, CommandHandler handler, string help)
    {
        commands.Add(command, new CommandRegistration(command, handler, help));
    }

    public void appendLogLine(string line)
    {
        Debug.Log(line);

        if (scrollback.Count >= ConsoleController.scrollbackSize)
        {
            scrollback.Dequeue();
        }
        scrollback.Enqueue(line);

        log = scrollback.ToArray();
        if (logChanged != null)
        {
            logChanged(log);
        }
    }

    public void runCommandString(string commandString)
    {
        appendLogLine("$ " + commandString);

        string[] commandSplit = parseArguments(commandString);
        string[] args = new string[0];
        if (commandSplit.Length < 1)
        {
            appendLogLine(string.Format("Unable to process command '{0}'", commandString));
            return;

        }
        else if (commandSplit.Length >= 2)
        {
            int numArgs = commandSplit.Length - 1;
            args = new string[numArgs];
            Array.Copy(commandSplit, 1, args, 0, numArgs);
        }
        runCommand(commandSplit[0].ToLower(), args);
        commandHistory.Add(commandString);
    }

    public void runCommand(string command, string[] args)
    {
        CommandRegistration reg = null;
        if (!commands.TryGetValue(command, out reg))
        {
            appendLogLine(string.Format("Unknown command '{0}', type 'help' for list.", command));
        }
        else
        {
            if (reg.handler == null)
            {
                appendLogLine(string.Format("Unable to process command '{0}', handler was null.", command));
            }
            else
            {
                reg.handler(args);
            }
        }
    }

    static string[] parseArguments(string commandString)
    {
        LinkedList<char> parmChars = new LinkedList<char>(commandString.ToCharArray());
        bool inQuote = false;
        var node = parmChars.First;
        while (node != null)
        {
            var next = node.Next;
            if (node.Value == '"')
            {
                inQuote = !inQuote;
                parmChars.Remove(node);
            }
            if (!inQuote && node.Value == ' ')
            {
                node.Value = '\n';
            }
            node = next;
        }
        char[] parmCharsArr = new char[parmChars.Count];
        parmChars.CopyTo(parmCharsArr, 0);
        return (new string(parmCharsArr)).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }

    #region Command handlers
    //Implement new commands in this region of the file.

    /// <summary>
    /// A test command to demonstrate argument checking/parsing.
    /// Will repeat the given word a specified number of times.
    /// </summary>
    void babble(string[] args)
    {
        if (args.Length < 2)
        {
            appendLogLine("Expected 2 arguments.");
            return;
        }
        string text = args[0];
        if (string.IsNullOrEmpty(text))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            int repeat = 0;
            if (!Int32.TryParse(args[1], out repeat))
            {
                appendLogLine("Expected an integer for arg2.");
            }
            else
            {
                for (int i = 0; i < repeat; ++i)
                {
                    appendLogLine(string.Format("{0} {1}", text, i));
                }
            }
        }
    }

    void give(string[] args)
    {
        string item = args[0];

        if (args.Length > 1)
        {
            for (int i = 1; i < args.Length; i++)
            {
                item = item + " " + args[i];
            }
        }

        if (string.IsNullOrEmpty(item))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            appendLogLine("Spawning Item " + item);
            if (ItemController.instance.items.ContainsKey(item))
            {
                if (ItemController.instance.AddItem(new gameItem(item), 0)==-1)
                    appendLogLine("Inventory full");
            }
            else
                appendLogLine("Couldnt Find item");
        }
    }


    void playtuto(string[] args)
    {
        if (args.Length < 1)
        {
            appendLogLine("Expected 1 arguments.");
            return;
        }
        string id = args[0];
        if (string.IsNullOrEmpty(id))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            SCP_UI.instance.ShowTutorial(id);

        }
    }

    void playsub(string[] args)
    {
        if (args.Length < 2)
        {
            appendLogLine("Expected 2 arguments.");
            return;
        }
        string id = args[0];
        if (string.IsNullOrEmpty(id))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            string table = args[1];
            if (string.IsNullOrEmpty(table))
            {
                appendLogLine("Expected arg2 to be text.");
            }
            else
            {
                SubtitleEngine.instance.playSub(table,id);
            }
        }
    }

    void playvoicesub(string[] args)
    {
        if (args.Length < 2)
        {
            appendLogLine("Expected 2 arguments.");
            return;
        }
        string chara = args[0];
        if (string.IsNullOrEmpty(chara))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            string voice = args[1];
            if (string.IsNullOrEmpty(voice))
            {
                appendLogLine("Expected arg2 to be text.");
            }
            else
            {

                        appendLogLine("Subtitle not found");
            }
        }
    }

    void sethealth(string[] args)
    {
        if (args.Length < 1)
        {
            appendLogLine("Expected 1 argument.");
            return;
        }
        else
        {
            float value = 0;
            if (!float.TryParse(args[0], out value))
            {
                appendLogLine("Expected an integer for arg1.");
            }
            else
            {
                GameController.instance.player.GetComponent<Player_Control>().Health = value;
            }
        }
    }

    void teleportRoom(string[] args)
    {
        if (args.Length < 1)
        {
            appendLogLine("Expected an argument.");
            return;
        }
        string text = args[0];
        if (string.IsNullOrEmpty(text))
        {
            appendLogLine("Expected arg1 to be text.");
        }
        else
        {
            if (GameController.instance.TeleportRoom(text))
                appendLogLine(string.Format("Teleporting to room {0}", text));
            else
                appendLogLine("Teleport Failed");
        }
    }

    void teleportCoord(string[] args)
    {
        if (args.Length < 2)
        {
            appendLogLine("Expected 2 arguments.");
            return;
        }
        int x = 0;
        if (!Int32.TryParse(args[0], out x))
        {
            appendLogLine("Expected an integer for arg1.");
        }
        else
        {
            int y = 0;
            if (!Int32.TryParse(args[1], out y))
            {
                appendLogLine("Expected an integer for arg2.");
            }
            else
            {
                GameController.instance.TeleportCoord(x, y);
                appendLogLine(string.Format("Teleporting to {0} {1}", x, y));
            }
        }
    }

    void echo(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string arg in args)
        {
            sb.AppendFormat("{0},", arg);
        }
        sb.Remove(sb.Length - 1, 1);
        appendLogLine(sb.ToString());
    }

    void noclip(string[] args)
    {
        GameController.instance.player.GetComponent<Player_Control>().SwitchNoClip();
    }

    void godmode(string[] args)
    {
        GameController.instance.playercache.godmode = !GameController.instance.playercache.godmode;
    }

    void spawn106(string[] args)
    {
        GameController.instance.CL_spawn106();
    }

    void spawn173(string[] args)
    {
        GameController.instance.CL_spawn173();
    }

    void spawn513(string[] args)
    {
        GameController.instance.CL_spawn513();
    }
    void spawn049(string[] args)
    {
        GameController.instance.CL_spawn049();
    }
    void spawn096(string[] args)
    {
        GameController.instance.CL_spawn096();
    }


    void help(string[] args)
    {
        if (args.Length == 1)
        {
            string command = args[0];
            if (string.IsNullOrEmpty(command))
            {
                appendLogLine("Expected arg1 to be text.");
            }
            else
            {
                CommandRegistration reg = null;
                if (!commands.TryGetValue(command, out reg))
                {
                    appendLogLine(string.Format("Unknown command '{0}', type 'help' for list.", command));
                }
                else
                {
                    appendLogLine(string.Format("{0}: {1}", reg.command, reg.help));
                }
            }

        }
        else
        foreach (CommandRegistration reg in commands.Values)
        {
            appendLogLine(string.Format("{0}: {1}", reg.command, reg.help));
        }
    }

    void hide(string[] args)
    {
        if (visibilityChanged != null)
        {
            visibilityChanged(false);
        }
    }

    void safeplace(string[] args)
    {
        GameController.instance.GoSafePlace();
    }

    void goPocket(string[] args)
    {
        GameController.instance.GoPocket();
    }

    void safereturn(string[] args)
    {
        GameController.instance.WorldReturn();
    }

    void repeatCommand(string[] args)
    {
        for (int cmdIdx = commandHistory.Count - 1; cmdIdx >= 0; --cmdIdx)
        {
            string cmd = commandHistory[cmdIdx];
            if (String.Equals(repeatCmdName, cmd))
            {
                continue;
            }
            runCommandString(cmd);
            break;
        }
    }

    void subcheck(string [] args)
    {
        Localization.AddMissing();
    }

    void resetPrefs(string[] args)
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    #endregion
}