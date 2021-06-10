using Godot;
using System;

public class Menu : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    PackedScene mainScene = (PackedScene)ResourceLoader.Load("Main.tscn");
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void _on_Button_pressed()
    {
        GetTree().ChangeSceneTo(mainScene);  
    }

    public void _on_Button3_pressed()
    {
        GetTree().Quit();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
