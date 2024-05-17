namespace _07_InterfaceSegregationPrinciple.Before
{
    interface IEntitlement
    { 
        decimal CalculatePension();
        decimal CalculateHealthInsurance();
        decimal CalculateRentalSubsidy();
        decimal CalculateBonuses();
        decimal CalculateTransportationReimbursement();

    }
}
