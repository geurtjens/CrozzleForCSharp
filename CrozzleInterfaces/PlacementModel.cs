namespace CrozzleInterfaces;

public readonly record struct PlacementModel
{
    public readonly byte w;
    public readonly byte x;
    public readonly byte y;
    private readonly byte _z;
    public readonly bool z => GetIsHorizontal();
    public readonly byte l => GetLength();

    public PlacementModel(byte w, byte x, byte y, bool z, byte l)
    {
        this.w = w;
        this.x = x;
        this.y = y;
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

