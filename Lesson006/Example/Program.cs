Console.Clear();

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeigthPosition = Console.WindowHeight / 2;
DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeigthPosition);
