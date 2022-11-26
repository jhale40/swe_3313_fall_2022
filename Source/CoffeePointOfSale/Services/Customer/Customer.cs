using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "anonymous";

    

    private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    private int _rewardPoints;
    //private string? _lastName;

    public Customer? currentCustomer { get; set; }   

    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual int RewardPoints

    {
        get => _rewardPoints;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPoints = value;
        }
    }


    public virtual string? LastName { get; set; }
    

    public virtual string? FirstName { get; set; }



    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public override string ToString()
    {
        return IsAnonymous  
            ? "Anonymous Customer - No Reward Points"
            : $"{LastName}, {FirstName}, {Phone}, Reward Points: {RewardPoints}";
    }
}