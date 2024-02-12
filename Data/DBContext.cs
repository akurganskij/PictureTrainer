using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    public DbSet<Image> images { get; set; } = null!;
    public DbSet<Tasks> tasks { get; set; } = null!;
	public DbSet<Problems> problems { get; set; } = null!;

	//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	//=> optionsBuilder.UseSqlite("Data Source=image.db");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.Entity<Problems>().ToTable("Problems");
		modelBuilder.Entity<Image>().ToTable("Images");
		modelBuilder.Entity<Tasks>().ToTable("Tasks");

		modelBuilder.Entity<Problems>().
			HasOne<Image>().WithOne().HasForeignKey<Image>(p => p.ProblemId);
		modelBuilder.Entity<Image>().
			HasMany<Tasks>().WithOne().HasForeignKey(p => p.ImageId);
	}
}
