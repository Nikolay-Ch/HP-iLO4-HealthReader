﻿namespace HPiLO4HealthReader.DTO
{
    public readonly record struct NetworkCard
    {
        public readonly string? PortName { get; init; }
        public readonly string? Mac { get; init;}
    }
}