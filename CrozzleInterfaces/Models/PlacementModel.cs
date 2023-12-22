namespace CrozzleInterfaces;

public readonly record struct PlacementModel
{
    public readonly byte W;
    public readonly byte X;
    public readonly byte Y;
    private readonly byte _z;
    public readonly bool Z => GetIsHorizontal();
    public readonly byte L => GetLength();

    public PlacementModel(byte w, byte x, byte y, bool z, byte l)
    {
        this.W = w;
        this.X = x;
        this.Y = y;
        if (z == true) {
            _z = (byte)(64 + l);
        } else {
            _z = l;
        }
    }

    private bool GetIsHorizontal()
    {
        if ((byte)(this._z & 64) == 64)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private byte GetLength()
    {
        return (byte)(this._z & 63);
    }
}

