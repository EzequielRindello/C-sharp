public class Can
{
    private string _name;
    private double _radius;
    private double _height;


    public Can(string name, double radius, double height)
    {
        this._name = name;
        this._radius = radius;
        this._height = height;
    }

    public float ComputeVolume()
    {
        return 0;
    }

    public float ComputeSurfaceArea()
    {
        return 0;
    }

    public float ComputeStorageEfficiency()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_name}";//{_storage}
    }
}