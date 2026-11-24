/*
Dungeon crawler spel

på ett 4x3 bräde spawnar det 8 rum, kanske slumpade
börja i ett rum
spawna två vaser/kistor i två olika rum. Nyckeln finns i en av vaserna.

spawna en nyckel i något av rummen

gå runt från de olika rummen, men inte teleportera. A<->B<->C osv
*/

using Raylib_cs;


Color ground = new(67, 75, 94);
Color wallcolor = new(28, 41, 71);
Rectangle wall = new(0, 0, 50, 800);


static void DrawRoom(Color ground, Rectangle wall, Color Wallcolor)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(ground);
    Raylib.DrawRectangleRec(wall, Wallcolor);
    Raylib.EndDrawing();
}

Raylib.InitWindow(1000, 800, "Dungeon crawler");
Raylib.SetTargetFPS(60);



while (!Raylib.WindowShouldClose())
{
    DrawRoom(ground, wall, wallcolor);
}
