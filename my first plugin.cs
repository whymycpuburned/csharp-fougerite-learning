using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fougerite;
public class fougerite : Fougerite.Module
{
    public override string Name
    {
        get { return "learning plugins/csharp"; }
    }
    public override string Author
    {
        get { return "whatmycpu"; }
    }
    public override string Description
    {
        get { return "First plugin"; }
    }
    public override Version Version
    {
        get { return new Version("0,1"); }
    }
    public override void Initialize()
    {
        Hooks.OnCommand += HandleCommand;
        Hooks.OnChat += HandleChat;
    }
    public override void DeInitialize()
    {
        Hooks.OnCommand -= HandleCommand;
        Hooks.OnChat -= HandleChat;
    }
    public void HandleCommand(Fougerite.Player player, string cmd, string[] args)
    {
        if (cmd == "test")
        {
            player.Message("You used /test command !");
        }
    }
    private void HandleChat(Fougerite.Player player, ref ChatString chatString)
    {

    }
}