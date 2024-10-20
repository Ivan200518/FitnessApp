namespace Fitness.BL.Model;
/// <summary>
/// Gender
/// </summary>
public class Gender
{
    /// <summary>
    /// Name of the gender
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// Create a new gender 
    /// </summary>
    /// <param name="name">Name of gender </param>
    /// <exception cref="ArgumentNullException"></exception>
    public Gender(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("Name cannot be null or empty", nameof(name));            
        }
        Name = name;        
    }

    public override string ToString()
    {
        return Name;
    }
}