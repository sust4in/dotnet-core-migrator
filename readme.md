# Dotnet Core Migrator

Because we can do it!

### Usage 

First, you should write a migration;

```csharp

public class MyMigration: Migration, IMigration {

    public void Execute()
    {
        migrator.Table("users");

        migrator.AddColumn(new VarChar("email", 100))
            .SetUnique()
            .SetNotNull();

        migrator.AddColumn(new VarChar("nickname", 100))
            .SetUnique()
            .SetNotNull();

        migrator.AddColumn(new VarChar("name", 100))
            .Add(),

        migrator.Create();
    }

} 
```

Then, you should run all migrations. Thats all!

```csharp
IAdaptor adaptor = new MySQLAdaptor("my_connection_string");
Migrator migrator = new Migrator(adaptor);
migrator.SetMigrationList(new List<IMigration>() {
    new MyMigration()
});
migrator.Migrate();
```