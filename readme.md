# Dotnet Core Migrator

Because we can do it!

### Usage 

First, you should write a migration;

```csharp
public class MyMigration: Migration, IMigration {

    public void Execute()
    {
        migrator.Table("users");

        migrator.AddColumn(new Int("id"))
            .PrimaryKey()
            .AutoIncrement()
            .Unique()
            .NotNull();        

        migrator.AddColumn(new VarChar("email", 100))
            .Unique()
            .NotNull();

        migrator.AddColumn(new VarChar("nickname", 100))
            .Unique()
            .NotNull();

        migrator.AddColumn(new VarChar("name", 100));

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
