﻿namespace Data.API;

public interface ICustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}