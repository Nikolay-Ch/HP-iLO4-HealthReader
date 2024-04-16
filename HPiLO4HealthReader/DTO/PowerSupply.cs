namespace HPiLO4HealthReader.DTO
{
    public readonly record struct PowerSupply
    {
        public string Label { get; init; }
        public string Status { get; init; }
    }
}
