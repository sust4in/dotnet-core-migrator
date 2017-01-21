# Dotnet Core Migrator

Because we can do it!

### Usage 

First, you should write a migration;

```csharp

public class MyMigration: Migration, IMigration {

    public void Execute()
    {
        db.Table("users")

            .Column(new VarChar("email", 100))
            .IsUnique()
            .IsNotNull()
            .Add()

            .Column(new VarChar("nickname", 100))
            .IsUnique()
            .IsNotNull()
            .Add()

            .Column(new VarChar("name", 100))
            .Add()

            .Create();
    }

} 
```

Then, you should run all migrations. Thats all!

```csharp
IAdaptor adaptor = DatabaseAdaptor.Get(DatabaseAdaptor.MYSQL, "my_connection_string");
Migrator migrator = new Migrator(adaptor);
migrator.SetMigrationList(new List<IMigration>() {
    new MyMigration()
});
migrator.Migrate();
```