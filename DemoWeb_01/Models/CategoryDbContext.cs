using Microsoft.EntityFrameworkCore;

namespace DemoWeb_01.Models
{
    //class này là class đại diện cho sql server ở trong visual
    //nếu muốn đụng chạm đến csdl: thêm sưa xóa hay gì đáy
    //thì nhớ lôi cô thằng này ra
    public class CategoryDbContext : DbContext
    {
        //cách 1: gắn chuỗi kết nối trực tiếp vào class dbcontext
        //contructor
        //k tham số: ctor + tab
        public CategoryDbContext()
        {
            
        }
        //có thâm số
        // ctrl + . => gennerate contructor =>...option
        public CategoryDbContext(DbContextOptions options) : base(options)
        {
        }

        //tạo db set tương ứng
        //nó là 1 thực thể đại diện cho 1 bảng ở trong csdl
        public DbSet<Category> Categories { get; set; }

        //ctrl + . => gennerate overdide => onconfig (db...)
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=NGUYEN_NGOC_HOA\\HOANN; Database=DbSD19315;Trusted_Connection= True;" +
        //                 "TrustServerCertificate=True");
        //}



        //NẾU MUỐN THÊM DATA LUÔN THÌ LÀM CÒN K THÌ THÔI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Ma=1, Name="sắn", Description= " trắng"},
                new Category { Ma=2, Name="ngô", Description= " trắng"},
                new Category { Ma=3, Name="khoai", Description= " trắng"},
                new Category { Ma=4, Name="Bắp", Description= " trắng"},
                new Category { Ma=5, Name="dứa", Description= " trắng"}
                );
        }
    }
}
