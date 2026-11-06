/*
name: Trick or Treater Farmer
description: This bot will keep killing the trick or treater.
tags: trick or treat, trickortreat, trick or treater
*/

using System;
using Skua.Core.Interfaces;

public class Script
{
    public void ScriptMain(Skua.Core.Interfaces.IScriptInterface Bot)
    {
        Random r = new Random();
        string mapName1 = new string("whitemap-");
        string mapName2 = new string("trickortreat-");

        while(!Bot.ShouldExit)
        {
            int rInt = r.Next(1000, 9999);

            Bot.Map.Join(mapName1 + rInt);
            Bot.Wait.ForMapLoad(mapName1 + rInt);

            Bot.Map.Join(mapName2 + rInt);
            Bot.Wait.ForMapLoad(mapName2 + rInt);

            Bot.Skills.LoadAdvanced(Bot.Player.CurrentClass.Name, true);
            Bot.Skills.Start();

            Bot.Kill.Monster("Trick Or Treater");
        }
    }
}