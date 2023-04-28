using Data.API;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
namespace Data.Implementation;

internal class DataContext : DbContext, IDataContext
{
    private const string defaultConnectionString = @"Data Source=LAPTOP-5T8JC9IH;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    internal List<ICustomer> CustomerList = new();
    internal List<IOrder> OrderList = new();
    internal List<IProduct> ProductList = new();
    internal List<IState> StateList = new();


    private readonly string _connectionString;

    public DataContext( string? connectionString = null)
    {
        this._connectionString = connectionString ?? defaultConnectionString;
    }

    public DbSet<Customer> _customers { get; set; }
    public IQueryable<ICustomer> Customer => _customers;
    public DbSet<Product> _products { get; set; }
    public IQueryable<IProduct> Product => _products;
    public DbSet<State> _states { get; set; }
    public IQueryable<IState> State => _states;
    public DbSet<Order> _orders { get; set; }
    public IQueryable<IOrder> Order => _orders;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);

    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.Entity<StateDTO>().HasOne(state => (CatalogDTO)state.Catalog);
    //     modelBuilder.Entity<ReturnDTO>().HasOne(@return => (StateDTO)@return.State);
    //     modelBuilder.Entity<RentDTO>().HasOne(rent => (StateDTO)rent.State);
    //     modelBuilder.Entity<ReturnDTO>().HasOne(@return => (UsersDTO)@return.User);
    //     modelBuilder.Entity<RentDTO>().HasOne(rent => (UsersDTO)rent.User);

    // }

    public async Task AddCustomerAsync(ICustomer customer)
    {
        Customer customerToAdd = new() { Id = customer.Id, FirstName = customer.FirstName, LastName = customer.LastName };
        await _customers.AddAsync(customerToAdd);
        await SaveChangesAsync();
    }

    public async Task AddProductAsync(IProduct product)
    {
        Product productToAdd = new() { Id = product.Id, Name = product.Name, Price = product.Price};
        await _products.AddAsync(productToAdd);
        await SaveChangesAsync();
    }

    public async Task AddStateAsync(IState state)
    {
        State stateToAdd = new() {Id = state.Id, ProductId = state.ProductId, Amount = state.Amount, isAvailable = true};
        await _states.AddAsync(stateToAdd);
        await SaveChangesAsync();
    }

    public async Task AddOrderAsync(IOrder order)
    {
        Order orderToAdd = new() {Id = order.Id, ProductId = order.ProductId, Amount = order.Amount,  UserId = order.UserId};
        await _orders.AddAsync(orderToAdd);
        await SaveChangesAsync();
    }

    
    public async Task DeleteCustomerAsync(int Id)
    {

        Customer? entityToRemove = await _customers.FindAsync(Id);
        if(entityToRemove != null)
        {
            _customers.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteProductAsync(int Id)
    {

        Product? entityToRemove = await _products.FindAsync(Id);
        if(entityToRemove != null)
        {
            _products.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
    public async Task DeleteStateAsync(int Id)
    {

        State? entityToRemove = await _states.FindAsync(Id);
        if(entityToRemove != null)
        {
            _states.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteOrderAsync(int Id)
    {

        Order? entityToRemove = await _orders.FindAsync(Id);
        if(entityToRemove != null)
        {
            _orders.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
}