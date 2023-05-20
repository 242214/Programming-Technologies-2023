<<<<<<< HEAD
﻿namespace Service.API;
=======
namespace Service.API;
>>>>>>> 3d203c770fb49572badc49f5fab5602c363eb3b2

public interface ICustomer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    Task AddAsync();
    Task DeleteAsync();
}