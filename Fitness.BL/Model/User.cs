namespace Fitness.BL.Model;

/// <summary>
/// Represents a user in the fitness application.
/// </summary>
public class User
{
    #region Properties

    /// <summary>
    /// Gets the name of the user.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the gender of the user.
    /// </summary>
    public Gender Gender { get; }

    /// <summary>
    /// Gets the date of birth of the user.
    /// </summary>
    public DateTime DateOfBirth { get; }

    /// <summary>
    /// Gets or sets the weight of the user in kilograms.
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// Gets or sets the height of the user in centimeters.
    /// </summary>
    public double Height { get; set; }

    #endregion

    /// <summary>
    /// Initializes a new instance of the User class.
    /// </summary>
    /// <param name="name">The name of the user.</param>
    /// <param name="gender">The gender of the user.</param>
    /// <param name="dateOfBirth">The date of birth of the user.</param>
    /// <param name="weight">The weight of the user in kilograms.</param>
    /// <param name="height">The height of the user in centimeters.</param>
    /// <exception cref="ArgumentNullException">Thrown when name or gender is null or empty.</exception>
    /// <exception cref="ArgumentException">Thrown when dateOfBirth, weight, or height is invalid.</exception>
    public User(string name, 
                Gender gender,
                DateTime dateOfBirth,
                double weight,
                double height)
    {
        #region Check conditions
        
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException("Name cannot be null or empty.", nameof(name));
        }
        if (gender == null)
        {
            throw new ArgumentNullException("Gender cannot be null.", nameof(gender));
        }
        if (dateOfBirth < DateTime.Parse("01.01.1900") || dateOfBirth > DateTime.Now)
        {
            throw new ArgumentException("Date of birth must be in the past and not later than today.", nameof(dateOfBirth));
        }
        if (weight <= 0 || weight > 300)
        {
            throw new ArgumentException("Weight must be more than 0 kg.", nameof(weight));
        }
        if (height <= 0 || height > 250)
        {
            throw new ArgumentException("Height must be more than 0 cm.", nameof(height));    
        }

        #endregion
        
        Name = name;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        Weight = weight;
        Height = height;
    }
    
    public override string ToString()
    {
        return Name;
    }
}