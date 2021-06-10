using Godot;
using System;

public class EnvironmentObjects : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    public int anzahl = 0;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Vector2 wdSize = Godot.OS.WindowSize;
        PackedScene envObject = (PackedScene)ResourceLoader.Load(this.GetType() + ".tscn");

        for (int i = 0; i < anzahl; i++)
        {
            Random randr = new Random();
            int x = randr.Next(0, (int)wdSize.x);
            int y = randr.Next(0, (int)wdSize.y);
            Node2D myEnvObj = (Node2D)envObject.Instance();
            myEnvObj.Position = new Vector2(x, y);
            GetTree().Root.AddChild(myEnvObj);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
