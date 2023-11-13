public struct XY
{
    public int x;
    public int y;

    public XY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static XY operator +(XY a, XY b) => new XY(a.x + b.x, a.y + b.y);
    public static XY operator -(XY a, XY b) => new XY(a.x - b.x, a.y - b.y);

    public override string ToString()
    {
        return $"{(char)('a' + x)}, {y + 1}";
    }
}