/*
Dungeon crawler spel

på ett 4x3 bräde spawnar det 8 rum, kanske slumpade
börja i ett rum
spawna två vaser/kistor i två olika rum. Nyckeln finns i en av vaserna.

spawna en nyckel i något av rummen

gå runt från de olika rummen, men inte teleportera. A<->B<->C osv
*/


using Raylib_cs;

Char p1 = new(); 

Room r1 = new();





Raylib.InitWindow(1000, 800, "Dungeon crawler");
Raylib.SetTargetFPS(60);



while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    r1.Draw();
    p1.DrawChar();

    Raylib.EndDrawing();
}

class Room
{
    Color ground = new(67, 75, 94);
    Color Wallcolor = new(28, 41, 71);
    Rectangle LeftWall = new(0, 0, 50, 800);
    Rectangle RightWall = new(950, 0, 50, 800);
    Rectangle TopWall = new(0, 0, 1000, 50);
    Rectangle BottomWall = new(0, 750, 1000, 50);

    public void Draw()
    {
        Raylib.ClearBackground(ground);
        Raylib.DrawRectangleRec(LeftWall, Wallcolor);
        Raylib.DrawRectangleRec(RightWall, Wallcolor);
        Raylib.DrawRectangleRec(TopWall, Wallcolor);
        Raylib.DrawRectangleRec(BottomWall, Wallcolor);
    }
}

class Char
{
    Color HFärg = new(145, 232, 23);
    Rectangle Size = new(450, 350, 50, 50);

    public void DrawChar()
    {
        Raylib.DrawRectangleRec(Size, HFärg);
    }
}
